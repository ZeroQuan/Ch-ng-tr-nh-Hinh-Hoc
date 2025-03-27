namespace QLHH_2200011643
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn Thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Lưu file
        private void btnLuu_Click(object sender, EventArgs e)
        {
            File.WriteAllText("dsnv.txt", txtDanhSach.Text);
            MessageBox.Show("Lưu file muốn dsnv.txt", "Thông báo");
        }

        //Nhập lại
        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtTrucDai.Clear();
            txtTrucNgan.Clear();
        }

        private void radChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxChuNhat.Enabled = radChuNhat.Checked;
            groupBoxTron.Enabled = false;
            groupBoxEllipse.Enabled = false;
        }

        private void radTron_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTron.Enabled = radTron.Checked;
            groupBoxEllipse.Enabled = false;
            groupBoxChuNhat.Enabled = false;
        }

        private void radEllipse_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxEllipse.Enabled = radEllipse.Checked;
            groupBoxChuNhat.Enabled = false;
            groupBoxTron.Enabled = false;
        }

        
        //Them
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (radTron.Checked)
            {
                if (!double.TryParse(txtBanKinh.Text, out double r) || r <= 0)
                {
                    MessageBox.Show("Bán kính phải là số thực dương");
                    return;
                }
                double S = Math.PI * r * r;
                txtDanhSach.AppendText($"\nTròn, R = {r}, S = {S:F3}\r");
            }
            else if (radChuNhat.Checked)
            {
                if (!double.TryParse(txtChieuDai.Text, out double d) || d <= 0 || !double.TryParse(txtChieuRong.Text, out double r) || r <= 0)
                {
                    MessageBox.Show("Dài và rộng phải là số thực dương");
                    return;
                }
                double S = d * r;
                txtDanhSach.AppendText($"\nChữ nhật, D = {d}, R = {r}, S = {S:F3}\r");
            }
            else if (radEllipse.Checked)
            {
                if (!double.TryParse(txtTrucDai.Text, out double a) || a <= 0 || !double.TryParse(txtTrucNgan.Text, out double b) || b <= 0)
                {
                    MessageBox.Show("Trục dài và trục ngắn phải là số thực dương");
                    return;
                }
                double S = (a / 2) * (b / 2) * Math.PI;
                txtDanhSach.AppendText($"\nEllipse, a = {a}, b = {b}, S = {S:F3}\r");
            }
        }
    }
}
