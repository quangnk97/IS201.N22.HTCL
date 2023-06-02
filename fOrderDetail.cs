using IS201_N22_HTCL.UserControls;
using System;
using System.Windows.Forms;

namespace IS201_N22_HTCL
{
    public partial class fOrderDetail : Form
    {
        int ID;
        string type;
        public fOrderDetail(int ID, string type)
        {
            InitializeComponent();
            this.ID = ID;
            this.type = type;
        }

        private void fOrderDetail_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case "Ordering":
                    UsCtr_OrderDetail usCtr_OrderDetail = new UsCtr_OrderDetail();
                    usCtr_OrderDetail.LoadData(ID);
                    pnviewOrder.Controls.Add(usCtr_OrderDetail);
                    break;
                case "Completed":
                    UsCtr_ReturningDisc usCtr_ReturningDisc = new UsCtr_ReturningDisc();
                    usCtr_ReturningDisc.LoadData(ID, 0);
                    pnviewOrder.Controls.Add(usCtr_ReturningDisc);

                    break;
                default:
                    UsCtr_ReturningDisc usCtr_ReturningDiscs = new UsCtr_ReturningDisc();
                    usCtr_ReturningDiscs.LoadData(ID, 1);
                    pnviewOrder.Controls.Add(usCtr_ReturningDiscs);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
