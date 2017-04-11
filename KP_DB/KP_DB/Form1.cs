using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KP_DB
{
    public partial class Form1 : Form
    {
        //Microsoft.Data.ConnectionUI.DataConnectionDialog dlg = new Microsoft.Data.ConnectionUI.DataConnectionDialog();
        //SqlConnection conn = new SqlConnection();
        SqlConnection conn = new SqlConnection(
            
           "Data Source = DESKTOP-O11MGK3;" + "Initial Catalog = GIBDD;" + "User ID = sa;" + "Password=1234;"
                   );
        public Form1()
        {
            InitializeComponent();

        }

        private void новоеСоединениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /* Microsoft.Data.ConnectionUI.DataSource.AddStandardDataSources(dlg);
             Microsoft.Data.ConnectionUI.DataConnectionDialog.Show(dlg);
             listBox1.Items.Add("Строка соединения:" + dlg.ConnectionString);
            
             conn.ConnectionString = dlg.ConnectionString;
            
             try
             {
                 listBox1.Items.Add("Соединение открыто");
                // MessageBox.Show("Соединение открыто" + dlg.ConnectionString);
                 conn.Open();
             }
             catch (SqlException ex)
             {
                 listBox1.Items.Add("Ошибка соединения");
                // MessageBox.Show("Ошибка соединения");
                 MessageBox.Show(ex.Message);
             }
             finally
             {
                 conn.Close();
                 listBox1.Items.Add("Соединение закрыто");
             }*/




        }

        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                listOfststus.Items.Add("Соединение закрыто");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.CommandText = "vivodUgonPoMarceModel";
            cmd1.Parameters.Add("@model", SqlDbType.NVarChar).Value = txtModel.Text;
            cmd1.Parameters.Add("@marca", SqlDbType.NVarChar).Value = txtMarca.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridViewAvto.DataSource = dt;
        }
    }
}
