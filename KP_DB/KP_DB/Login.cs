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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
               "Data Source = DESKTOP-O11MGK3;" + "Initial Catalog = GIBDD;" + "User ID = sa;" + "Password=1234;"
                   );
            
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginUserIn";

            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = txtLogin.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPas.Text;

            cmd.Parameters.Add("@result", SqlDbType.Int);
            cmd.Parameters["@result"].Direction = ParameterDirection.Output;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Boolean isAdmin = false;
            Boolean isUser = false;

            switch (Convert.ToInt32(cmd.Parameters["@result"].Value))
            {
                case 1:
                    if (Convert.ToString(cmd.Parameters["@name"].Value) == "Admin")
                        isAdmin = true;
                    else isUser = true;
                    txtLogin.Clear();
                    txtPas.Clear();
                    break;

                case -1:
                    txtPas.Clear();
                    MessageBox.Show("Введен неправильный логин/пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            if (isAdmin)
            {
                isAdmin = false;
                AdminForm admin = new AdminForm();
                admin.Show();
                

            }
            if (isUser)
            {
                isUser = false;
                UserForm user = new UserForm();
                user.Show();
              

            }


        }

        private void txtPas_TextChanged(object sender, EventArgs e)
        {
            txtPas.PasswordChar = '*';
        }
    }
}
