
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication4
{
    class DataBase
    {
        static string connectionString = "server=localhost;port=3306;database=project;uid=root;pwd=root;";
        MySqlConnection conn = new MySqlConnection(connectionString);
        string query;

        MySqlCommand myCommand;
        MySqlDataReader myReader;

        public void Showtable(DataGridView tbl, string table)
        {

            try
            {
                query = " select * from " + table + ";";
                myCommand = new MySqlCommand(query, conn);
                MySqlDataAdapter sda = new MySqlDataAdapter {SelectCommand = myCommand};
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource {DataSource = dbdataset};

                tbl.DataSource = bSource;

                sda.Update(dbdataset);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public List<string> SelectItem(string table, string item)
        {
            try
            {

                query = "select " + item + " from " + table + ";";
                List<string> list = new List<string>();
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    list.Add(myReader.GetValue(0).ToString());
                }

                myReader.Close();
                conn.Close();
                return list;


            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open")
                { conn.Close(); }
                List<string> list = new List<string>() { e.Message };
                MessageBox.Show(e.Message + "\n" + e.ToString());

                return list;
            }


        }
        public string select_asArray(string table, string item, string equal1, string equal2)
        {
            try
            {
                query = "select " + item + " from " + table + " where " + equal1 + " = " + equal2 + ";";
                string a = "";
                List<string> list = new List<string>();
                myCommand = new MySqlCommand(query, conn);
                conn.Open();
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    a = Convert.ToString(myReader[0]);

                }
                myReader.Close();
                conn.Close();
                return a;
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                List<string> list = new List<string>();
                list.Add(e.Message);
                MessageBox.Show(e.Message + "\n" + e.ToString());

                return "";
            }
        }
        public void insert_toDatabase(string table, string columns, string values)
        {
            try
            {
                query = "insert into " + table + " (" + columns + ") values(" + values + ");";
                myCommand = new MySqlCommand(query, conn);

                conn.Open();
                myCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                if (conn.State.ToString() == "Open") { conn.Close(); }
                MessageBox.Show(e.Message);
                return;
            }
        }
    }
}
