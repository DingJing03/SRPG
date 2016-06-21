using System;
using System.Collections;
using System.Reflection;
using Model.Util;

namespace DAL.Base
{
    public static class SetupBase
    {
        public static string CreateTableObjects(ArrayList tableObjects)
        {
            string messageHtml = string.Empty;
            foreach(Object o in tableObjects)
            {
                DataTableAttribute[] customAttribute = (DataTableAttribute[])o;
                string tableName = customAttribute[0].TableName;
                if(customAttribute[0].TableName != "")
                {
                    
                }
            }
            return null;
        }
    }

    private static string LookupTable(Object o, string tableName)
    {
        PropertyInfo[] propertys = o.GetType().GetProperties();
        string sqlHtml = string.Empty;
        sqlHtml += "if exists";
        sqlHtml += "create table " + tableName + "";

        return sqlHtml;
    }
}
