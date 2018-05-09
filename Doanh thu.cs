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
    public partial class formDT : Form
    {
        public formDT()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NL36GS2\SQLEXPRESS;Initial Catalog=Quanlybanhang;Integrated Security=True");
        private void Hienthi()
        {
            
            string sql = " SELECT * from vwDoanhthuCH";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            
            string sql1 = "insert  [tblHoaDonBan] set  NgayBan= @NgayBan";
            SqlCommand cmd = new SqlCommand(sql1, conn);
            string NgayBan = pck.Value.ToString("yyyy-MM-dd");
            cmd.Parameters.AddWithValue("NgayBan", NgayBan);
        }

        private void formDT_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain fdt = new frmMain();
            fdt.ShowDialog();
            this.Close();
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            int sc = dataGridView1.Rows.Count;
            int Tongtien = 0;
            for (int i = 0; i < sc - 1; i++)
                Tongtien += int.Parse(dataGridView1.Rows[i].Cells["Tổng tiền"].Value.ToString());
            txtDT.Text = Tongtien.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bmp, 250, 90);
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
