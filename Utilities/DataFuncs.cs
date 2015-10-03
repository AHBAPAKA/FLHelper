using FlickrNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SvetanFlickrApp
{
    public class DataFuncs
    {
        public static List<FavsToDelete> FavsToDeleteList;
        public static List<string> MyFriendsList;

        public static void BulkInsert<T>(string connection, string tableName, IList<T> list)
        {
            using (var bulkCopy = new SqlBulkCopy(connection))
            {
                bulkCopy.BatchSize = list.Count;
                bulkCopy.DestinationTableName = tableName;

                var table = new DataTable();
                var props = TypeDescriptor.GetProperties(typeof(T))
                    //Dirty hack to make sure we only have system data types 
                    //i.e. filter out the relationships/collections
                                           .Cast<PropertyDescriptor>()
                                           .Where(propertyInfo => propertyInfo.PropertyType.Namespace.Equals("System"))
                                           .ToArray();

                foreach (var propertyInfo in props)
                {
                    bulkCopy.ColumnMappings.Add(propertyInfo.Name, propertyInfo.Name);
                    table.Columns.Add(propertyInfo.Name, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);
                }

                var values = new object[props.Length];

                foreach (var item in list)
                {
                    for (var i = 0; i < values.Length; i++)
                    {
                        values[i] = props[i].GetValue(item);
                    }
                    table.Rows.Add(values);
                }

                bulkCopy.WriteToServer(table);

            }

        }

        public static void BindGrid<T>(IList<T> bindingsource, DataGridView dgv)
        {
            bindingsource = bindingsource.Distinct<T>().ToList<T>();
            BindingSource grigbindingSource = new BindingSource();
            grigbindingSource.DataSource = bindingsource;
            dgv.DataSource = grigbindingSource;

        }

        public static void BindGrid(List<MyFlickrContact> bindingsource, DataGridView dgv)
        {
            bindingsource = bindingsource.GroupBy(x => x.LastPhotoID).Select(y => y.First()).ToList<MyFlickrContact>();
            BindingSource grigbindingSource = new BindingSource();
            grigbindingSource.DataSource = bindingsource;
            dgv.DataSource = grigbindingSource;
            dgv.Visible = true;

        }

        public static List<Fav> GetSavedFavsList()
        {
            List<Fav> retval = new List<Fav>();
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                retval = (from f in db.Favs
                           select f).ToList<Fav>();
            }

            return retval;
        }

        public static List<FavsToDelete> GetSavedFavsToDEleteList()
        {
            List<FavsToDelete> retval = new List<FavsToDelete>();
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                retval = (from f in db.FavsToDeletes
                          select f).ToList<FavsToDelete>();
            }

            return retval;
        }

        public static List<string> MyFriends()
        {
            List<String> retList = new List<string>();
            string appfolder = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName;
            string docpath = Path.Combine(appfolder, @"XML\ExcludeFromDeleteFav.xml");
            XmlTextReader reader = new XmlTextReader(docpath);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        retList.Add(reader.Value);

                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }

            return retList;
        }

        public static void PopulateMyFriensList()
        {
            MyFriendsList = MyFriends();
        }

        public static void PopulateCustomCollection(PhotoCollection rowfavs)
        {
            //FlickrFavorite lfavs = new List<FlickrFavorite>();

            foreach (var f in rowfavs)
            {
                if (!MyFriendsList.Contains(f.UserId))
                {
                    FavsToDelete fav = new FavsToDelete();
                    fav.photoID = f.PhotoId;
                    if (f.DateFavorited.Value != null)
                    {
                        fav.DateAdded = f.DateFavorited.Value;
                    }
                    else
                    {
                        fav.DateAdded = DateTime.Now.AddMonths(-8);
                    }


                    FavsToDeleteList.Add(fav);
                }
                else
                {
                }


            }


        }

        public static void LoadDBFavsToDelete()
        {
            try
            {
                using (DataClasses1DataContext db = new DataClasses1DataContext())
                {
                    db.ExecuteCommand("DELETE FROM FavsToDelete");


                    FavsToDeleteList.GroupBy(i => i.photoID).Select(group => group.First());
                    FavsToDeleteList.OrderByDescending(d => d.DateAdded);

                    DataFuncs.BulkInsert(db.Connection.ConnectionString, "FavsToDelete", FavsToDeleteList);

                }
            }
            catch (Exception exp)
            {

                //throw;
            }
        }


    }


}
