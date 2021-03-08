using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 实训ATM机
{
    public partial class UserForm : Form
    {
     
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        { //显示账户余额
            
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//关闭当前窗口

        }

        private void btnDepos_Click(object sender, EventArgs e)
        {
            Form DeopAndWithdraw1 = new DeopAndWithdraw();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Form DeopAndWithdraw1 = new DeopAndWithdraw();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            Form Tranfer1 = new Tranfer();
        }

        private void btnChangePassw_Click(object sender, EventArgs e)
        {
            Form ChangePassword1 = new ChangePassword();
        }
    }
}

