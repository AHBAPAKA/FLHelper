using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using FlickrNet;

namespace SvetanFlickrApp
{
    #region Delegates/Events

    public delegate void ProgressFeedbackDelegate(string msg, int counter);

    public delegate void SessionEndDelegate(string msg, int counter);

    public delegate void ProgressResetDelegate(string msg);

    #endregion Delegates/Events

    public class DataFuncs
    {
        public static event ProgressResetDelegate OnProgressReset;

        public static event ProgressFeedbackDelegate OnFeedback;

        public static List<FavsToDelete> FavsToDeleteList;
        public static List<string> MyFriendsList;
        // A delegate type for hooking up change notifications.

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
            //grigbindingSource.SupportsSorting = true;
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

        public static List<MyPeople> LoadMyPeople()
        {
            List<MyPeople> retval = new List<MyPeople>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                retval = (from f in db.MyPeoples
                          select f).ToList<MyPeople>();
            }

            return retval;
        }

        public static List<MyContact> LoadMyContact()
        {
            List<MyContact> retval = new List<MyContact>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                retval = (from f in db.MyContacts
                          select f).ToList<MyContact>();
            }

            return retval;
        }

        public static List<Group> LoadGroup()
        {
            List<Group> retval = new List<Group>();

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                retval = (from f in db.Groups
                          select f).ToList<Group>();
            }

            return retval;
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

        public static void ProcessLastUploadedPhotoDT(Flickr flickr)
        {
            List<MyPeople> people = LoadMyPeople();
            int icount = 1;
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                foreach (MyPeople person in people)
                {
                    FireCount("Processing item " + icount.ToString(), people.Count);
                    person.LastPostedImage = FlickrFuncs.GetLastUploadedPhotoDT(person.UserId, flickr);
                    MyPeople pr = db.MyPeoples.Where(a => a.UserId == person.UserId).FirstOrDefault<MyPeople>();
                    pr.LastPostedImage = person.LastPostedImage;
                    db.SubmitChanges();
                    icount++;
                }
            }
        }

        private static void FireCount(string msg, int count)
        {
            if (OnFeedback != null)
                OnFeedback(msg, count);
            Application.DoEvents();
        }

        private static void FireResetStatus(string msg)
        {
            //LogManager.LogInfo(msg, true);
            if (OnProgressReset != null)
                OnProgressReset(msg);
            Application.DoEvents();
        }
    }
}