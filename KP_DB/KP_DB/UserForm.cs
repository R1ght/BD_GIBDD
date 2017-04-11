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
    public partial class UserForm : Form
    {
        
        SqlConnection conn = new SqlConnection(
               "Data Source = DESKTOP-O11MGK3;" + "Initial Catalog = GIBDD;" + "User ID = sa;" + "Password=1234;"
                   );
        public UserForm()
        {
            InitializeComponent();
            selectInAvto.Checked = true;
            selectOfShtraf.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
           
            if (selectInAvto.Checked == true)
            {
                //txtCode.Visible = false;
                conn.Open();
                //SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-O11MGK3; " + "Initial Catalog = GIBDD; " + "User ID = sa; " + "Password = 1234;");


                cmd1.CommandText = "vivodUgon";
                cmd1.Parameters.Add("@model", SqlDbType.NVarChar).Value = txtModel.Text;
                cmd1.Parameters.Add("@marca", SqlDbType.NVarChar).Value = txtMarca.Text;
                //cmd1.Parameters["@result"].Direction = ParameterDirection.Output;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridViewAvto.DataSource = dt;

                conn.Close();
            }
            if (selectInCode.Checked == true)
            {
                //txtCode.Visible = false;
                conn.Open();
                //SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-O11MGK3; " + "Initial Catalog = GIBDD; " + "User ID = sa; " + "Password = 1234;");

                

                cmd1.CommandText = "vivodUgonPoGosNomeru";
                cmd1.Parameters.Add("@gosnomer", SqlDbType.NVarChar).Value = txtCode.Text;
                cmd1.Parameters.Add("@region", SqlDbType.NVarChar).Value = txtRegion.Text;
                //cmd1.Parameters["@result"].Direction = ParameterDirection.Output;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridViewAvto.DataSource = dt;

                conn.Close();
            }

        }

        private void selectInAvto_CheckedChanged(object sender, EventArgs e)
        {
            if(selectInAvto.Checked == true)
            {
                panelCode.Visible = false;
                panelAvto.Visible = true;
            } 
            else
                if(selectInCode.Checked == true)
                {
                    panelAvto.Visible = false;
                    panelCode.Visible = true;
                }

        }

        private void btnSearchInFIO_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            
            if (selectOfShtraf.Checked == true)
            {
                conn.Open();
              


                cmd1.CommandText = "PoiskShtrafa";
                cmd1.Parameters.Add("@fam", SqlDbType.NVarChar).Value = txtFam.Text;
                cmd1.Parameters.Add("@imya", SqlDbType.NVarChar).Value = txtImya.Text;
                cmd1.Parameters.Add("@otchestvo", SqlDbType.NVarChar).Value = txtOtchestvo.Text;
                //cmd1.Parameters["@result"].Direction = ParameterDirection.Output;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridViewFio.DataSource = dt;

                conn.Close();
            }
            if (SearchOfAvto.Checked == true)
            {
                conn.Open();
                



                cmd1.CommandText = "PoiskAvtoInFIO";
                cmd1.Parameters.Add("@fam", SqlDbType.NVarChar).Value = txtFam.Text;
                cmd1.Parameters.Add("@imya", SqlDbType.NVarChar).Value = txtImya.Text;
                cmd1.Parameters.Add("@otchestvo", SqlDbType.NVarChar).Value = txtOtchestvo.Text;
               
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(dt);
                dataGridViewFio.DataSource = dt;

                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.CommandText = "VivodStrah";
            cmd1.Parameters.Add("@name", SqlDbType.NVarChar).Value = textStrah.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridViewStrah.DataSource = dt;

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.CommandText = "InfStrah";
            cmd1.Parameters.Add("@fam", SqlDbType.NVarChar).Value = txtFamStrah.Text;
            cmd1.Parameters.Add("@imya", SqlDbType.NVarChar).Value = txtNameStrah.Text;
            cmd1.Parameters.Add("@otchestvo", SqlDbType.NVarChar).Value = txtOtchestvoStrah.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridViewInfStrah.DataSource = dt;

            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.CommandText = "vivodVIN";
            cmd1.Parameters.Add("@number", SqlDbType.NVarChar).Value = textBoxVIN.Text;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridViewVIN.DataSource = dt;
            conn.Close();
        }
    }
}
