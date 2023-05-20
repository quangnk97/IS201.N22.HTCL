using System.Windows.Forms;

namespace IS201.N22.HTCL
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            fLogin form = new fLogin();
            //form1.Size = new System.Drawing.Size(1600, 900);
            Application.Run(form);
        }
    }
}
