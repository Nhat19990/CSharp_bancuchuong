namespace CSharp_bancuchuong
{
    public partial class bangcuuchuong2 : Form
    {
        public bangcuuchuong2()
        {
            InitializeComponent();
        }


        private void btnxem_Click_1(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtso.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblketqua.Text += Environment.NewLine + so.ToString() + " x " + i.ToString() + " = " + (so * i).ToString();
            }
        }
    }
}
