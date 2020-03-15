using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;

namespace MilliSoft.Metod
{
      public class BaseMethod<TT> : MSInterface<TT>
    {
        Type Tip 
        {
            get
            {
                return typeof(TT);
            }
        }
        public DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Connect;
            cmd.CommandText = string.Format("Select{0}", Tip.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
       

        public bool Insert(TT ms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Insert{0}", Tip.Name);
            cmd.Connection = Tools.Connect;
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] prop = Tip.GetProperties();
            foreach (PropertyInfo item in prop)
            {
                string paramsname ="@"+ item.Name;
                object paramsvalue = item.GetValue(ms);
                cmd.Parameters.AddWithValue(paramsname, paramsvalue);

            }
            return Tools.ExecuteNonQuery(cmd);

            
        }

       

        public bool Update(TT ms)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Update{0}", Tip.Name);
            cmd.Connection = Tools.Connect;
            cmd.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] prop = Tip.GetProperties();
            foreach (PropertyInfo item in prop)
            {
                string paramsname = "@" + item.Name;
                object paramsvalue = item.GetValue(ms);
                cmd.Parameters.AddWithValue(paramsname, paramsvalue);

            }
            return Tools.ExecuteNonQuery(cmd);
        }
        public bool Delete(int Id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Delete{0}", Tip.Name);
            cmd.Connection = Tools.Connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
