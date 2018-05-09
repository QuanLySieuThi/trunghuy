using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_bán_hàng
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            
        }

       

        private void itemKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            formKH fkh = new formKH() ;
            fkh.ShowDialog();
            this.Close();

        }

        private void ItemNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            formNhanvien fNV = new formNhanvien();
            fNV.ShowDialog();
            this.Close();

        }

        private void ItemNhaCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            formnhacc fNCC = new formnhacc();
            fNCC.ShowDialog();
            this.Close();
        }

        private void ItemMH_Click(object sender, EventArgs e)
        {

            this.Hide();
            formMatHang fMH = new formMatHang();
            fMH.ShowDialog();
            this.Close();

        }

        private void ItemHDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHDB fHDB = new formHDB();
            fHDB.ShowDialog();
            this.Close();
        }

        private void ItemHDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHDN fHDN = new formHDN();
            fHDN.ShowDialog();
            this.Close();
        }

        private void itemTKMH_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTKMH ftkMH = new formTKMH();
            ftkMH.ShowDialog();
            this.Close();
        }

        private void ItemTKNCC_Click(object sender, EventArgs e)
        {
            this.Hide();
            formtkNCC fTKncc = new formtkNCC();
            fTKncc.ShowDialog();
            this.Close();
        }

        private void ItemTKKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTKKH ftkKH = new formTKKH();
            ftkKH.ShowDialog();
            this.Close();
        }

        private void ItemBC_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDT fDT = new formDT();
            
            fDT.ShowDialog();
            this.Close();
        }

       

        private void itemDoipass_Click(object sender, EventArgs e)
        {
            this.Hide();
            formdoipass fDP = new formdoipass();
            fDP.ShowDialog();
            this.Close();
        }

        private void itemThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void iemTKMH_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTK fHT = new formTK();
            fHT.ShowDialog();
            this.Close();
        }
    }
}
