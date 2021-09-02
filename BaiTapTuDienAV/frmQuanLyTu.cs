using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ApplicationBlocks.Data;

namespace BaiTapTuDienAV
{
    public partial class frmQuanLyTu : Form
    {
        public frmQuanLyTu()
        {
            InitializeComponent();
           
        }
        //sự kiện khi vừa load form lên
        private void frmQuanLyTu_Load(object sender, EventArgs e)
        {
            //khi chậy form tự load data
            loaddata();
            //tự động xóa trắng text box
            btXoaTrang.PerformClick(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                //khia báo các biến truyền  vào 
                string id = txtID.Text.Trim();
                string eng = txtEnglish.Text.Trim();
                string shorvn = txtShorVN.Text.Trim();
                string dich = txtDich.Text.Trim();
                // truyền dữ liệu lên sql
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Them", id, eng, shorvn, dich);
                MessageBox.Show("Thêm thành công ");
                loaddata();

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loaddata()
        {
            gridItemData.DataSource = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_Select").Tables[0];

        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        private void setvalue(int index)
        {
            try
            {
                //tạo 1 DataGridView
                DataGridViewRow row = gridItemData.Rows[index];
                //truyền ngược giá trị vào text box
                txtID.Text = row.Cells[0].Value.ToString();
                txtEnglish.Text = row.Cells[1].Value.ToString();
                txtShorVN.Text = row.Cells[2].Value.ToString();
                txtDich.Text = row.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridItemData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            setvalue(e.RowIndex);
        }

        private void btXoaTrang_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtEnglish.Clear();
            txtShorVN.Clear();
            txtDich.Clear();

        }

        private void frmQuanLyTu_Click(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Xoa", id);
                MessageBox.Show("xóa thành công");
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                string eng = txtEnglish.Text.Trim();
                string shorvn = txtShorVN.Text.Trim();
                string dich = txtDich.Text.Trim();
                SqlHelper.ExecuteNonQuery(SQLstring.strCon, "TuDien_Sua", id, eng, shorvn, dich);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
