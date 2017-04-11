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
    public partial class AdminForm : Form
    {
        SqlConnection conn = new SqlConnection(
               "Data Source = DESKTOP-O11MGK3;" + "Initial Catalog = GIBDD;" + "User ID = sa;" + "Password=1234;"
                   );
        SqlDataAdapter dataAdapter;
        DataSet ds;
        SqlCommandBuilder cb;
        String TableName = "";
        public AdminForm()
        {
            InitializeComponent();
            
        }

        private void groupBox1_EnabledChanged(object sender, EventArgs e)
        {
           
            dataAdapter.Update(ds, TableName);
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataAdapter.Update(ds, TableName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения! Проверьте правильность ввода данных.", "Ошибка!", MessageBoxButtons.OK);
                return;
            };
            MessageBox.Show("Сохранение успешно!", "Сообщение", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Tables[TableName].Rows[dataGridView1.CurrentRow.Index].Delete();
                MessageBox.Show("Удаление успешно!", "Сообщение", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            finally
            {
                dataAdapter.Update(ds, TableName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           // rbTableAvto.Checked = true;

           // this.Text = TableName;

            if (rbTableAvto.Checked == true)
            {
                TableName = "Автомобиль";

            }
            if (rbTableDriver.Checked == true)
            {
                TableName = "Водитель inner join Клиент on Водитель.ID_Клиента=Клиент.ID_Клиента";


            }
            if (rbTableOner.Checked == true)
            {
                TableName = "Владелец inner join Клиент on Владелец.ID_Клиента=Клиент.ID_Клиента";

            }
            if (rbTableStrah.Checked == true)
            {
                TableName = "Страховка";

            }
            if (rbTableProt.Checked == true)
            {
                TableName = "Протокол";

            }
            if (rbTableStrahComp.Checked == true)
            {
                TableName = "СтраховыеКомпании";

            }
            if (rbPrava.Checked == true)
            {
                TableName = "ВодительскоеУдостоверение";
            }
            if (rbShtraf.Checked == true)
            {
                TableName = "Штрафы";
            }

            dataAdapter = new SqlDataAdapter("SELECT * FROM " + TableName, conn);
            cb = new SqlCommandBuilder(dataAdapter);
            ds = new DataSet();
            dataAdapter.Fill(ds, TableName);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            
        }

        
    }
}
