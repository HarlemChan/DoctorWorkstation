using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doctor_Workstation.公共类;
using System.Data.SqlClient;

namespace Doctor_Workstation
{
    public partial class frm_NewCaseHistory : Form
    {
        public frm_NewCaseHistory()
        {
            InitializeComponent();
            this.LoadNewPatient();
        }
        private void LoadNewPatient()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand=new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = $"Select PatientID,HospitalizedNo,DoctorID,Name,Sex,BedNo,PrincipalDiagnosis,DoctorName FROM tb_Patient WHERE CaseHistory='新入病人';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand=sqlCommand;
            DataTable dataTable=new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_NewPatient.DataSource=dataTable;
        }

        private void frm_NewCaseHistory_Load(object sender, EventArgs e)
        {
            this.BackColor=Color.DarkGray;
            dgv_NewPatient.Columns[2].Visible = false;
            dgv_NewPatient.ForeColor = Color.MediumBlue;
            dgv_NewPatient.DefaultCellStyle.BackColor = Color.DarkGray;
            dgv_NewPatient.BackgroundColor = Color.DarkGray;
            dgv_NewPatient.Columns["PatientID"].HeaderText = "病人ID";
            dgv_NewPatient.Columns["HospitalizedNo"].HeaderText = "住院号";
            dgv_NewPatient.Columns["Name"].HeaderText = "姓名";
            dgv_NewPatient.Columns["Sex"].HeaderText = "性别";
            dgv_NewPatient.Columns["BedNo"].HeaderText = "床号";
            dgv_NewPatient.Columns["PrincipalDiagnosis"].HeaderText = "主要诊断";
            dgv_NewPatient.Columns["DoctorName"].HeaderText = "经治医生";
        }

        private void dgv_NewPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string patientID = this.dgv_NewPatient.CurrentRow.Cells["PatientID"].Value.ToString();
            Patient.PatientID = patientID;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string patientID = this.dgv_NewPatient.CurrentRow.Cells["PatientID"].Value.ToString();
            Patient.PatientID = patientID;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            int RowAffected =sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if(RowAffected>0)
            {
                MessageBox.Show("新建病人成功！");
                this.LoadNewPatient();
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
