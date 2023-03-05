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
    public partial class frm_CaseHistoryShiftIn : Form
    {
        public frm_CaseHistoryShiftIn()
        {
            InitializeComponent();
            this.LoadShiftInPatient();
        }
        private void LoadShiftInPatient()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=DoctorWorkstation;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText=
                $"Select PatientID,HospitalizedNo,DoctorID,Sex,Name  FROM tb_Patient Where DoctorDepartment='{User.Department}' AND CaseHistory='移出病历';";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            dgv_ShiftInPatient.DataSource = dataTable;
        }

        private void frm_CaseHistoryShiftIn_Load(object sender, EventArgs e)
        {
            this.dgv_ShiftInPatient.ColumnHeadersVisible = false;
            this.dgv_ShiftInPatient.RowHeadersVisible=false;
            this.dgv_ShiftInPatient.Columns["DoctorID"].Visible=false;
            this.dgv_ShiftInPatient.Columns["Sex"].Visible = false;

        }
    }
}
