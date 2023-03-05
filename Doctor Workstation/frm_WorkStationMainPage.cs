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
    public partial class frm_WorkStationMainPage : Form
    {
        public frm_WorkStationMainPage()
        {
            InitializeComponent();
            this.LoadPatient();
        }
        private void LoadPatient()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                $"Select PatientID,Name From tb_Patient Where DoctorID='{User.UserID}' AND CaseHistory='正常状态';";
            sqlCommand2.Connection = sqlConnection;
            sqlCommand2.CommandText = $"Select *  FROM tb_Doctor WHERE DoctorID='{User.UserID}';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand=sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            sqlConnection.Open();
            SqlDataReader sqlDataReader=sqlCommand2.ExecuteReader();
            if(sqlDataReader.Read())
            {
                User.Department = sqlDataReader["Department"].ToString();
                User.UserName=sqlDataReader["Name"].ToString();
            }
            sqlDataReader.Close();
            dgv_Patient.DataSource = dataTable;
        }

        private void frm_WorkStationMainPage_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.grp_CaseHistory.Visible=false;
            this.grp_CaseHistory.BackColor=Color.White;
            this.lbl_UserMessage.Text = "您好！"+User.UserName;
            this.lbl_UserMessage.ForeColor = Color.Blue;
            this.btn_Quit.ForeColor = Color.Red;
            this.btn_Quit.BackColor = Color.White;
            btn_CaseHistory.BackColor = Color.White;
            btn_CaseHistory.ForeColor = Color.Blue;
            btn_DiseaseProgress.BackColor = Color.White;
            btn_Examine.BackColor= Color.White;
            btn_DoctorAdvice.BackColor = Color.White;
            btn_Checkout.BackColor= Color.White;
            btn_HomePage.BackColor= Color.White;
            btn_Temperature.BackColor= Color.White;
            dgv_Patient.BackgroundColor = Color.White;
            dgv_Patient.Columns[1].HeaderText = "病人列表";
            dgv_Patient.Columns[0].Visible = false;
        }


        private void dgv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ShiftOut_Click(object sender, EventArgs e)
        {
            string patientID = this.dgv_Patient.CurrentRow.Cells["PatientID"].Value.ToString();
            Patient.PatientID = patientID;
            MessageBox.Show(Patient.PatientID);
        }

        private void btn_CaseHistory_Click(object sender, EventArgs e)
        {
            btn_CaseHistory.BackColor= Color.Gray;
            grp_CaseHistory.Visible = true;
            grp_CaseHistory.BackColor = Color.Gray;
            string patientID = this.dgv_Patient.CurrentRow.Cells["PatientID"].Value.ToString();
            Patient.PatientID = patientID;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            grp_CaseHistory.Visible= false;
            grp_CaseHistory.BackColor=Color.Gray;
            btn_CaseHistory.BackColor = Color.White;
        }

        private void btn_NewConstruction_Click(object sender, EventArgs e)
        {
            frm_NewCaseHistory frm_NewCaseHistory = new frm_NewCaseHistory();
            this.Hide();
            frm_NewCaseHistory.ShowDialog();
            this.Dispose();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            frm_Login frm_Login=new frm_Login();
            this.Hide();
            frm_Login.ShowDialog();
            this.Dispose();
            User.UserID = null;
            User.UserName = null;
            Patient.PatientID = null;
        }

        private void btn_ShiftOut_Click_1(object sender, EventArgs e)
        {
            frm_DoctorSingnature frm_DoctorSingnature = new frm_DoctorSingnature();
            this.Hide();
            frm_DoctorSingnature.ShowDialog();
            this.Dispose();

        }

        private void btn_ShiftIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.Department);
            frm_CaseHistoryShiftIn frm_CaseHistoryShiftIn=new frm_CaseHistoryShiftIn();
            this.Hide();
            frm_CaseHistoryShiftIn.ShowDialog();
            this.Dispose();
        }
    }
}
