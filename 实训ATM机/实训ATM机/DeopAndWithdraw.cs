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
    public partial class DeopAndWithdraw : Form
    {
        public DeopAndWithdraw()
        {
            
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int cos=0;
            switch  (cos)
            {
                case 1:
                    break;
                case 2:break;
                default:MessageBox.Show("错误");break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeopAndWithdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
