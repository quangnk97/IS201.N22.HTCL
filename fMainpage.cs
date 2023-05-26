using IS201.N22.HTCL.Service;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IS201.N22.HTCL
{
    public partial class fMainPage : Form

    {
        //UsCtr_HomePage HomePage;
        //UsCtr_Cart Cart;
        //UsCtr_Manage Manage;
        //UsCtr_Order Order;
        //ShopView Store;
        //UsCtr_UserProfilecs UserProfilecs;
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public fMainPage(fLogin login)
        {
            InitializeComponent();
            //HomePage = new UsCtr_HomePage();
            //Cart = new UsCtr_Cart();
            //Manage = new UsCtr_Manage();
            //Order = new UsCtr_Order();
            //Store = new ShopView();
            //UserProfilecs = new UsCtr_UserProfilecs();
            //pnView.Controls.Add(HomePage);
            //pnView.Controls.Add(Cart);
            //pnView.Controls.Add(Manage);
            //pnView.Controls.Add(Order);
            //pnView.Controls.Add(Store);
            //pnView.Controls.Add(UserProfilecs);
            //HomePage.BringToFront();
            SetVisibleMenu();
        }

        private void SetVisibleMenu()
        {
            //con.Open();
            //string getName = "SELECT POSITION_NAME  FROM users, POSITION WHERE users.USER_POSITION = POSITION.POSITION_ID and USER_ID = " + fLogin.ID;
            //SqlDataAdapter da = new SqlDataAdapter(getName, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //con.Close();
            //string name = dt.Rows[0]["POSITION_NAME"].ToString().Trim();
            //if (name.CompareTo("Customer") == 0)
            //{
            //    btnOrder.Visible = false;
            //    btnManage.Visible = false;
            //}
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void fMainPage_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


    }
}
