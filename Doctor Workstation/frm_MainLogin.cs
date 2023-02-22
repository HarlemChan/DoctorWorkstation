using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_Workstation
{
    public partial class frm_MainLogin : Form
    {
        public frm_MainLogin()
        {
            InitializeComponent();
        }

        private void btn_MainLogin_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login = new frm_Login();
            this.Hide();
            frm_Login.ShowDialog();
            this.Dispose();
        }

        private void frm_MainLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
