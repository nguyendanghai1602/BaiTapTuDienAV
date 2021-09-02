using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//khi báo sử dụng thư viện SQLhelper
using Microsoft.ApplicationBlocks.Data;

namespace BaiTapTuDienAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttraTu_Click(object sender, EventArgs e)
        {
            //khi cần tra từ hiện thằng chương trình
            frmMainApp frmMain = new frmMainApp();
            frmMain.Show();
            this.Hide();

        }

        private void btQL_Click(object sender, EventArgs e)
        {
            //khi cần thêm từ thì hiện cho hiện from đăng nhập để quản lý từ
            groupBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xử lý nút đăng nhập 
            //khi bấm đăng nhập  thì nó sẽ kiểm tra với Database xem có tồn tại user và pass này không, nếu có mwor from Quản Lý lên 
            try
            {
                //khai báo 2 biến chuỗi sẽ chứu giá trị được nhập từ TextBox
                string user = txtUser.Text.Trim();//Trim dùng để xóa khoảng cách đầu và cuối chuỗi user nếu nhập nhầm 
                string pass = txtPass.Text.Trim();
                //sẽ tạo 1 bảng trắng chứa table mình sẽ get về (nếu có)
                //cấu trúc câu lệnh SQLHelper (chuỗi kết nối, tên proceduce, biến truyền vào nếu có)
                DataTable dt = SqlHelper.ExecuteDataset(SQLstring.strCon, "Login_Select", user, pass).Tables[0];
                //xử lý khi người dùng nhập đúng
                if(dt.Rows.Count > 0)// số row phải lớn hơn 0 nếu trùng user và pass
                {
                    frmQuanLyTu frm = new frmQuanLyTu();
                    frm.Show();//cho hiện cái form quản lý lên 
                    this.Hide();
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
