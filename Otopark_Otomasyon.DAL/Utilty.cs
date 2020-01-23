using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public static class Utilty
    {
        private readonly static string ConnectionKey = @"C:\Users\Mehmeto\Documents\Visual Studio 2015\Projects\Otopark_Otomasyon\Otopark_Web\bin\myDB.sqlite";

        public static SQLiteConnection GetConnection()
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + ConnectionKey + ";Version=3;", true);
            return conn;
        }


        public static int RunExecuteNonQuery(SQLiteCommand command)
        {
            try
            {
                command.Connection = GetConnection();
                if (command.Connection.State == ConnectionState.Closed)
                {
                    command.Connection.Open();
                }
                
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public static DataTable RunDataReader(SQLiteCommand command)
        {
            try
            { /*
                using (var c = new SQLiteConnection(GetConnection()))
                {
                    c.Open();
                }
                */
                command.Connection = GetConnection();
                if (command.Connection.State == ConnectionState.Closed)
                {
                    command.Connection.Open();
                }
                SQLiteDataReader dr = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }

    }
}
