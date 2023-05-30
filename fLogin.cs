using IS201_N22_HTCL.Service;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IS201_N22_HTCL
{
    public partial class fLogin : Form
    {
        public static int ID;
        public static string permission;
        public static string acc;

        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                message.Caption = "Please fill out the information";
                message.Show();
            }
            else
            {
                con.Open();
                string login = "SELECT * FROM USERS WHERE user_name= '" + tbUsername.Text.Trim() + "' and user_password= '" + tbPassword.Text.Trim() + "'";
                cmd = new SqlCommand(login, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    acc = tbUsername.Text;
                    ID = int.Parse(SQLConnection.GetFieldValues("SELECT USER_ID FROM USERS WHERE USER_NAME = '" + acc + "'"));
                    permission = (string)(SQLConnection.GetFieldValues("SELECT POSITION_NAME FROM USERS, POSITION WHERE USERS.USER_POSITION = POSITION.POSITION_ID AND USER_NAME = '" + acc + "'"));
                    this.Hide();
                    fMainPage mainPage = new fMainPage(this);
                    mainPage.ShowDialog();
                    this.Close();
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
                else
                {
                    message.Caption = "Incorrect information";
                    message.Show();
                }
            }
            con.Close();
        }
    }
}
