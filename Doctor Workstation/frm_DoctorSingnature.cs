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
using Doctor_Workstation.公共类;

namespace Doctor_Workstation
{
    public partial class frm_DoctorSingnature : Form
    {
        public frm_DoctorSingnature()
        {
            InitializeComponent();
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
            sqlCommand.Parameters.AddWithValue("@UserID", txb_UserID.Text.Trim());
            sqlCommand.Parameters["@UserID"].SqlDbType = SqlDbType.VarChar;
            sqlCommand.Parameters.AddWithValue("@Password", txb_Password.Text.Trim());
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            if (rowCount == 1)
            {
                SqlCommand sqlCommand2 = new SqlCommand();
                sqlCommand2.Connection=sqlConnection;
                sqlCommand2.CommandText =
                    $@"UPDATE tb_Patient SET CaseHistory='移出病历'WHERE PatientID='{Patient.PatientID}';";
                sqlConnection.Open();
                int RowAffected = sqlCommand2.ExecuteNonQuery();
                sqlConnection.Close();
                if(RowAffected>0)
                {
                    MessageBox.Show("完成医生签名,病历已移出");
                    frm_WorkStationMainPage frm_WorkStationMainPage = new frm_WorkStationMainPage();
                    this.Hide();
                    frm_WorkStationMainPage.ShowDialog();
                    this.Dispose();
                }




            }
            else
            {
                MessageBox.Show("用户名/口令有误，请重新输入！");
                this.txb_Password.Focus();
                this.txb_Password.SelectAll();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            frm_WorkStationMainPage frm_WorkStationMainPage = new frm_WorkStationMainPage();
            this.Hide();
            frm_WorkStationMainPage.ShowDialog();
            this.Dispose();
        }
    }
}
