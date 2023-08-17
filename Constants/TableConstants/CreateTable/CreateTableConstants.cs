using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_ScriptGenUtility.Constants.TableConstants.CreateTable
{
    public class CreateTableConstants
    {
        //Table Name
        public string tableName = string.Empty;
        public List<Columns>? columns = null;
    }

    public class Columns
    {
        //For Column 
        public string columnName = string.Empty;
        public string columnDataType = string.Empty;
        public bool isNotNull = false;
        public bool isUnique = false;
        public bool isPrimaryKey = false;
        public bool isForeignKey = false;

        //For primary key identity(Start,Increment_By)
        public int pk_identityFrom = 1;
        public int pk_identityTo = 1;

        //For varchar data type
        public int varcharLength = 0;

        //For Foreign Key to Refer another Table and its Primary Key
        public string fk_TableName = string.Empty;
        public string fk_ColumnName = string.Empty;
    }
}
