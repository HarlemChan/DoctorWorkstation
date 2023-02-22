using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Doctor_Workstation
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =
                $"SELECT COUNT(1) FROM tb_User" +
                $" WHERE UserID=@UserID" +
                $" AND Password=HASHBYTES('MD5',@Password);";
            sqlCommand.Parameters.AddWithValue("@UserID", txb_LoginID.Text.Trim());
            sqlCommand.Parameters["@UserID"].SqlDbType = SqlDbType.VarChar;
            sqlCommand.Parameters.AddWithValue("@Password", txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                MessageBox.Show("登录成功。");
                frm_WorkStationMainPage frm_WorkStationMainPage = new frm_WorkStationMainPage();
                this.Hide();
                frm_WorkStationMainPage.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("用户名/口令有误，请重新输入！");
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }
        }
    }
}
