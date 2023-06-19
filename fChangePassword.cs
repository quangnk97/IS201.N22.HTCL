using IS201_N22_HTCL.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS201_N22_HTCL
{
    public partial class fChangePassword : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Checked)
            {
                tbNewPass.PasswordChar = '\0';
                tbOldPass.PasswordChar = '\0';

            }
            else
            {
                tbNewPass.PasswordChar = '•';
                tbOldPass.PasswordChar = '•';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnConfirm_Click(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "" || tbOldPass.Text == "")
            {
                lbNotification.Text = "Not enough information";
            }
            else
            {
                string password = "";
                con.Open();
                string loadDT = "select USER_PASSWORD from USERS where USER_ID = @ID";
                SqlCommand cmd = new SqlCommand(loadDT, con);
                cmd.Parameters.AddWithValue("@ID", fLogin.ID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        password = reader["USER_PASSWORD"].ToString();
                    }
                    reader.Close();
                }
                con.Close();

                if (tbOldPass.Text != password)
                {
                    lbNotification.Text = "Incorrect current password";
                }
                else
                {
                    con.Open();
                    string update = "update USERS set USER_PASSWORD = @NewPass where USER_ID = @ID";
                    cmd = new SqlCommand(update, con);
                    cmd.Parameters.AddWithValue("@NewPass", tbNewPass.Text);
                    cmd.Parameters.AddWithValue("@ID", fLogin.ID);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    lbNotification.Text = "Update successful!";
                    message.Caption = "Update successful!";
                    message.Show();
                    this.Close();
                }
            }
        }
    }
}
