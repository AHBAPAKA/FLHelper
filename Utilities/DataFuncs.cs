using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SvetanFlickrApp
{
    public class DataFuncs
    {

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

        }
    }
}
