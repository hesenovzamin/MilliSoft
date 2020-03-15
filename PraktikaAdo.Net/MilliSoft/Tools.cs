using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace MilliSoft
{
    class Tools
    {
		private static SqlConnection connect;

		public static SqlConnection Connect
		{
			get 
			{
				if (connect == null)
				{
					connect = new SqlConnection(ConfigurationManager.ConnectionStrings["MilliSoftDB"].ConnectionString);

				}
				return connect;
			}
		}
		public static bool ExecuteNonQuery(SqlCommand cmd)
		{
			try
			{
				if (cmd.Connection.State == ConnectionState.Closed)
				{
					cmd.Connection.Open();
				}
				if (cmd.ExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception)
			{

				return false;
			}
			finally {
				if (cmd.Connection.State == ConnectionState.Open)
				{
					cmd.Connection.Close();
				}
			}
		}


	}
}
