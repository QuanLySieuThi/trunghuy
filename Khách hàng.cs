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

namespace Quản_lý_bán_hàng
{
    public partial class formKH : Form
    {   
        public formKH()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NL36GS2\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True");
        private void Khách_hàng_Load(object sender, EventArgs e)
        {
            conn.Open();
            Hienthi();
        }


        
        public void Hienthi()   // phương thức hiển thị
        {
            string sqlselect = "select * from tblKhachHang";
            SqlCommand cmd = new SqlCommand(sqlselect, conn); // thực thi lệnh sql trên với kết nối conn
            SqlDataReader dr = cmd.ExecuteReader();// đọc csdl
            DataTable dt = new DataTable();
            dt.Load(dr);           // bảng đọc dữ liệu của sql datareader
            dataGridView1.DataSource = dt;       // cho vào data gridview

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlthem = "insert into tblKhachHang values ( @maKH, @tenKh, @SDT)";
                SqlCommand cmd = new SqlCommand(sqlthem, conn);  // đọc lệnh
                cmd.Parameters.AddWithValue("maKH", txtmaKH.Text);
                cmd.Parameters.AddWithValue("tenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
                cmd.ExecuteNonQuery();
                Hienthi();
            }
            catch(Exception)
            {
                MessageBox.Show(" Mã đã tồn tại", "Lỗi");
            }

            if (txtmaKH.Text == "")
            {
                MessageBox.Show("Hãy nhập mã khách hàng ", "Chú ý");
                txtmaKH.Select();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng ", "Chú ý");
                txtTenKH.Select();
                return;
            }


            if (txtSDT.Text == "")
            {
                MessageBox.Show("Hãy nhập số điện thoại của khách hàng ", "Chú ý");
                txtSDT.Select();
                return;
            }

        }

       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlxoa = "Delete from tblKhachHang where maKH= @maKH";
            SqlCommand cmd = new SqlCommand(sqlxoa, conn);  // đọc lệnh
            cmd.Parameters.AddWithValue("maKH", txtmaKH.Text);
            cmd.ExecuteNonQuery();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Hienthi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fKH = new frmMain();
            fKH.ShowDialog();
            this.Close();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (txtmaKH.Text == "")
            {
                MessageBox.Show("Hãy nhập mã khách hàng ", "Chú ý");
                txtmaKH.Select();
                return;
            }
            if (txtTenKH.Text == "")
            {
                MessageBox.Show("Hãy nhập tên khách hàng ", "Chú ý");
                txtTenKH.Select();
                return;
            }


            if (txtSDT.Text == "")
            {
                MessageBox.Show("Hãy nhập số điện thoại của khách hàng ", "Chú ý");
                txtSDT.Select();
                return;
            }
            try
            {
                string sqlsua = "Update tblKhachHang Set  tenKH= @tenKH,  SDT= @SDT where maKH= @maKH";
                SqlCommand cmd = new SqlCommand(sqlsua, conn);  // đọc lệnh
                cmd.Parameters.AddWithValue("maKH", txtmaKH.Text);
                cmd.Parameters.AddWithValue("tenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("SDT", txtSDT.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Bạn đã sửa thành công", "Thông báo");
                Hienthi();
            }
            catch
            {
                MessageBox.Show("Xem lại thông tin nhập", "Chú ý");
            }

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtmaKH.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();//chạy từ 0 nha..
            txtTenKH.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            txtSDT.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            
        }
    }
}   