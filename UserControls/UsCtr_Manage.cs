using IS201_N22_HTCL.Service;
using LiveCharts;
using LiveCharts.Wpf;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace IS201_N22_HTCL.UserControls
{
    public partial class UsCtr_Manage : UserControl
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(SQLConnection.connectionString);
        public static DataTable dataTable;
        SqlDataAdapter adapter = new SqlDataAdapter();
        FireBaseService fireBaseService = new FireBaseService();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dtProducer = new DataTable();
        DataTable dtGenre = new DataTable();


        public UsCtr_Manage()
        {
            InitializeComponent();
            btnImportDisc.Enabled = false;
            LoadDataDisc();
            LoadDataDiscImport();
            LoadDataToComboboxDisc();
            LoadDataToSearchBox();

            cbMode.SelectedIndex = 0;
            cbValues.SelectedIndex = 0;
        }

        private void LoadDataToSearchBox()
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

            con.Open();
            string loadDT = "select DISC_NAME from DISC";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    auto.Add(reader["DISC_NAME"].ToString());

                }
            }
            tbxDisc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxDisc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxDisc.AutoCompleteCustomSource = auto;

            tbxSearchDisc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxSearchDisc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxSearchDisc.AutoCompleteCustomSource = auto;
            con.Close();

        }

        private int GetPositionID(string position)
        {
            int pos = 0;
            cbPosition.SelectedItem.ToString();
            con.Open();
            string loadDT = "select POSITION_ID from POSITION where POSITION_NAME = '" + position + "'";
            SqlCommand cmd = new SqlCommand(loadDT, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pos = (int)reader["POSITION_ID"];
                }
                reader.Close();
            }
            con.Close();
            return pos;
        }

        private void LoadDataDiscImport()
        {
            con.Open();
            string sql = "select DISC_ID, DISC_NAME, DISC_INSTOCK, DISC_PRICE from DISC";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gvListDisc.DataSource = dt;
        }

        private void LoadDataDisc()
        {
            con.Open();
            string sql = "select DISC_ID, DISC_NAME, PRODUCER_NAME, GENRE_NAME, DISC_AMOUNT, DISC_PRICE from DISC, PRODUCER, GENRE " +
                            "where DISC.DISC_PRODUCER = PRODUCER.PRODUCER_ID and DISC.DISC_GENRE = GENRE.GENRE_ID";
            cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            gvDisc.DataSource = dt;
        }

        private void LoadDataToComboboxDisc()
        {
            con.Open();
            da = new SqlDataAdapter("select PRODUCER_NAME from PRODUCER", con);
            da.Fill(dtProducer);
            con.Close();

            cbProducer.DataSource = dtProducer;
            cbProducer.DisplayMember = "Producer name";
            cbProducer.ValueMember = "PRODUCER_NAME";


            con.Open();
            da = new SqlDataAdapter("select GENRE_NAME from GENRE", con);
            da.Fill(dtGenre);
            con.Close();

            cbGenre.DataSource = dtGenre;
            cbGenre.DisplayMember = "Genre name";
            cbGenre.ValueMember = "GENRE_NAME";
        }



        private void btnAddDisc_Click(object sender, System.EventArgs e)
        {
            if (CheckInputDisc() == false)
            {

            }
            else
            {
                int genreID = GetGenreID();
                int producerID = GetProducerID();
                con.Open();
                string check = "SELECT DISC_NAME FROM DISC WHERE DISC_NAME = '" + tbDiscName.Text.Trim() + "'";
                cmd = new SqlCommand(check, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    messageDisc.Caption = tbDiscName.Text.Trim() + " is existing in store!";
                    messageDisc.Show();
                }
                else
                {
                    con.Close();
                    con.Open();
                    string register = "insert into DISC (DISC_NAME, DISC_AMOUNT,DISC_INSTOCK, DISC_PRICE,DISC_PRODUCER , DISC_GENRE)  values " +
                            "('" + tbDiscName.Text.Trim() + "'," + nbAmount.Value + "," + nbAmount.Value + "," + tbRentPrice.Text + "," +
                            producerID + "," + genreID + ")";
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    int discID = 0;
                    con.Open();
                    string loadDT = "select DISC_ID from DISC where DISC_NAME = '" + tbDiscName.Text.Trim() + "'";
                    cmd = new SqlCommand(loadDT, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            discID = (int)reader["DISC_ID"];
                        }
                        reader.Close();
                    }
                    con.Close();
                    fireBaseService.PushImage(pcDisc, "Disc/" + discID);
                    //fireBaseService.RetrieveImage(pcDisc, "Disc/" + tbDiscID);
                    LoadDataDisc();
                    LoadDataDiscImport();

                }
                con.Close();

            }
        }

        private bool CheckInputDisc()
        {
            if (tbDiscName.Text == "")
                return false;
            if (cbProducer.Text == "")
                return false;
            if (tbRentPrice.Text == "")
                return false;
            if (cbGenre.Text == "")
                return false;
            return true;
        }

        private int GetGenreID()
        {
            int genreID = 0;
            con.Open();
            string check = "SELECT GENRE_ID FROM GENRE WHERE GENRE_NAME = '" + cbGenre.Text.Trim() + "'";
            cmd = new SqlCommand(check, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    genreID = (int)dr["GENRE_ID"];
                }
                dr.Close();
            }
            con.Close();
            return genreID;
        }

        private int GetProducerID()
        {
            int producerID = 0;
            con.Open();
            string check = "SELECT PRODUCER_ID FROM PRODUCER WHERE PRODUCER_NAME = '" + cbProducer.Text.Trim() + "'";
            cmd = new SqlCommand(check, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    producerID = (int)dr["PRODUCER_ID"];
                }
                dr.Close();
            }
            con.Close();
            return producerID;
        }

        private void gvListDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscIDIm.Text = gvListDisc.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDiscNameIm.Text = gvListDisc.Rows[e.RowIndex].Cells[1].Value.ToString();
            nbInstockIm.Text = gvListDisc.Rows[e.RowIndex].Cells[2].Value.ToString();
            btnImportDisc.Enabled = true;

            fireBaseService.RetrieveImage(pbDiscIm, "Disc/" + gvListDisc.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void btnImportDisc_Click(object sender, System.EventArgs e)
        {
            con.Open();
            string register = "update disc set DISC_AMOUNT = DISC_AMOUNT + " + nbAmountIm.Value +
                ", DISC_INSTOCK = DISC_INSTOCK + " + nbAmountIm.Value + "where disc_id = " + tbDiscIDIm.Text.Trim();
            cmd = new SqlCommand(register, con);
            cmd.ExecuteNonQuery();
            con.Close();
            LoadDataDiscImport();
            LoadDataDisc();
        }

        private void gvDisc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            tbDiscID.Text = gvDisc.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbDiscName.Text = gvDisc.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbProducer.SelectedIndex = cbProducer.FindStringExact(gvDisc.Rows[e.RowIndex].Cells[2].Value.ToString());
            cbGenre.SelectedIndex = cbGenre.FindStringExact(gvDisc.Rows[e.RowIndex].Cells[3].Value.ToString());
            tbRentPrice.Text = gvDisc.Rows[e.RowIndex].Cells[5].Value.ToString();
            nbAmount.Text = gvDisc.Rows[e.RowIndex].Cells[4].Value.ToString();

            fireBaseService.RetrieveImage(pcDisc, "Disc/" + gvDisc.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdateDisc_Click(object sender, System.EventArgs e)
        {
            if (CheckInputDisc() == false)
            {

            }
            else
            {
                int genreID = GetGenreID();
                int producerID = GetProducerID();
                if (tbDiscID.Text == "")
                {
                    messageDisc.Caption = "Please choose an disc to edit";
                    messageDisc.Show();
                }
                else
                {
                    con.Open();
                    string register = "update DISC set DISC_NAME = '" + tbDiscName.Text.Trim() + "', DISC_AMOUNT = " + nbAmount.Value +
                        ", DISC_PRODUCER = " + producerID + ", DISC_PRICE = " + tbRentPrice.Text + ", DISC_GENRE = " + genreID + " where DISC_ID = " + tbDiscID.Text;
                    cmd = new SqlCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    fireBaseService.PushImage(pcDisc, "Disc/" + tbDiscID.Text);
                    fireBaseService.RetrieveImage(pcDisc, "Disc/" + tbDiscID.Text);
                    LoadDataDisc();
                }
                con.Close();

                LoadDataDiscImport();
            }
        }

        private void pcDisc_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose image";
            ofd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image img = new Bitmap(ofd.FileName);
                pcDisc.Image = img.GetThumbnailImage(360, 200, null, new IntPtr());
            }
        }

        private void tbxDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbxDisc.Text != "")
                {
                    con.Open();
                    string sql = "select DISC_ID, DISC_NAME, PRODUCER_NAME, GENRE_NAME, DISC_AMOUNT, DISC_PRICE from DISC, PRODUCER, GENRE " +
                                    "where DISC.DISC_PRODUCER = PRODUCER.PRODUCER_ID and DISC.DISC_GENRE = GENRE.GENRE_ID and DISC_NAME = '" + tbxDisc.Text.Trim() + "'";
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    gvDisc.DataSource = dt;
                }
                else
                {
                    LoadDataDisc();
                }
            }
        }

        private void tbxSearchDisc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbxSearchDisc.Text != "")
                {
                    con.Open();
                    string sql = "select DISC_ID, DISC_NAME, DISC_INSTOCK, DISC_PRICE from DISC, PRODUCER, GENRE " +
                                    "where DISC.DISC_PRODUCER = PRODUCER.PRODUCER_ID and DISC.DISC_GENRE = GENRE.GENRE_ID and DISC_NAME = '" + tbxSearchDisc.Text.Trim() + "'";
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.Text;
                    da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    gvListDisc.DataSource = dt;
                }
                else
                {
                    LoadDataDiscImport();
                }
            }
        }

        private void tbxSearchDisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRentPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (btnShowPassword.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }
    }
}
