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
    public partial class frmMainApp : Form
    {
        public frmMainApp()
        {
            InitializeComponent();
        }
        //khi form load tự động làm 
        private void frmMainApp_Load(object sender, EventArgs e)
        {
            LoadListboxData();
        }
        private void LoadListboxData()
        {
            try
            {
                //lấy các Item có trong data base
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_Select").Tables[0];
                //đổ Item ra listboxx
                lbItem.DataSource = ds;
                lbItem.DisplayMember = "English";//cho hiển thị cột tiếng anh
                lbItem.ValueMember = "ID";//giá trị theo cột english


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btTraTu_Click(object sender, EventArgs e)
        {
            try
            {
                string eng = txtEnglish.Text.Trim();
                //giá trị tìm được sẽ chứa trong 1 Table tạm để đưa ra Text box
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_TraTu", eng).Tables[0];
                //kiểm tra xem từ này có tồn tại trong CSDL không 
                if(ds.Rows.Count >0)
                {
                    txtVNShort.Text = ds.Rows[0]["ShortVN"].ToString();
                    txtVN.Text = ds.Rows[0]["VN"].ToString();
                   
                }   
                else
                {
                    MessageBox.Show("từ bạn tra hiện chưa có");
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbItem_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = lbItem.Text;//biến temp sẽ tạm chứa giá trị của Item mà người dung đang click vào 
                //mà giá trị ở đây không phải là tên english mà là ID theo từ english đó 
                //thế nên phải tạo 1 store proceduce nữa để bắt nó ra 
                DataTable ds = SqlHelper.ExecuteDataset(SQLstring.strCon, "TuDien_TraTu", temp).Tables[0];
                //truyền giá trị người dùng click vào textbox
                txtEnglish.Text = lbItem.Text;
                if(ds.Rows.Count >0)
                {
                    txtVNShort.Text = ds.Rows[0]["ShortVN"].ToString();
                    txtVN.Text = ds.Rows[0]["VN"].ToString();
                }
                else
                {
                    MessageBox.Show("từ bạn tra không có trong CSDL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
