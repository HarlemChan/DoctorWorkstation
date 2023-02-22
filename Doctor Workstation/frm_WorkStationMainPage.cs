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
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =
                $"Select PatientID,Name From tb_Patient";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand.CommandText, sqlConnection.ConnectionString);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgv_Patient.DataSource = dataSet.Tables[0];
            sqlCommand.Clone();
        }

        private void frm_WorkStationMainPage_Load(object sender, EventArgs e)
        {
            dgv_Patient.BackgroundColor = Color.White;
        }
    }
}
