namespace Doctor_Workstation
{
    partial class frm_WorkStationMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Patient = new System.Windows.Forms.DataGridView();
            this.btn_DiseaseProgress = new System.Windows.Forms.Button();
            this.btn_Examine = new System.Windows.Forms.Button();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.btn_HomePage = new System.Windows.Forms.Button();
            this.btn_Temperature = new System.Windows.Forms.Button();
            this.btn_DoctorAdvice = new System.Windows.Forms.Button();
            this.btn_CaseHistory = new System.Windows.Forms.Button();
            this.grp_CaseHistory = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_ShiftIn = new System.Windows.Forms.Button();
            this.btn_ShiftOut = new System.Windows.Forms.Button();
            this.btn_NewConstruction = new System.Windows.Forms.Button();
            this.lbl_UserMessage = new System.Windows.Forms.Label();
            this.btn_Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.grp_CaseHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(1, 0);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.RowTemplate.Height = 23;
            this.dgv_Patient.Size = new System.Drawing.Size(148, 411);
            this.dgv_Patient.TabIndex = 0;
            this.dgv_Patient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Patient_CellContentClick);
            // 
            // btn_DiseaseProgress
            // 
            this.btn_DiseaseProgress.Location = new System.Drawing.Point(212, 115);
            this.btn_DiseaseProgress.Name = "btn_DiseaseProgress";
            this.btn_DiseaseProgress.Size = new System.Drawing.Size(75, 23);
            this.btn_DiseaseProgress.TabIndex = 1;
            this.btn_DiseaseProgress.Text = "病程";
            this.btn_DiseaseProgress.UseVisualStyleBackColor = true;
            // 
            // btn_Examine
            // 
            this.btn_Examine.Location = new System.Drawing.Point(212, 144);
            this.btn_Examine.Name = "btn_Examine";
            this.btn_Examine.Size = new System.Drawing.Size(75, 23);
            this.btn_Examine.TabIndex = 2;
            this.btn_Examine.Text = "检查";
            this.btn_Examine.UseVisualStyleBackColor = true;
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Location = new System.Drawing.Point(212, 173);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(75, 23);
            this.btn_Checkout.TabIndex = 3;
            this.btn_Checkout.Text = "检验";
            this.btn_Checkout.UseVisualStyleBackColor = true;
            // 
            // btn_HomePage
            // 
            this.btn_HomePage.Location = new System.Drawing.Point(212, 202);
            this.btn_HomePage.Name = "btn_HomePage";
            this.btn_HomePage.Size = new System.Drawing.Size(75, 23);
            this.btn_HomePage.TabIndex = 4;
            this.btn_HomePage.Text = "首页";
            this.btn_HomePage.UseVisualStyleBackColor = true;
            // 
            // btn_Temperature
            // 
            this.btn_Temperature.Location = new System.Drawing.Point(212, 231);
            this.btn_Temperature.Name = "btn_Temperature";
            this.btn_Temperature.Size = new System.Drawing.Size(75, 23);
            this.btn_Temperature.TabIndex = 5;
            this.btn_Temperature.Text = "体温";
            this.btn_Temperature.UseVisualStyleBackColor = true;
            // 
            // btn_DoctorAdvice
            // 
            this.btn_DoctorAdvice.Location = new System.Drawing.Point(212, 260);
            this.btn_DoctorAdvice.Name = "btn_DoctorAdvice";
            this.btn_DoctorAdvice.Size = new System.Drawing.Size(75, 23);
            this.btn_DoctorAdvice.TabIndex = 6;
            this.btn_DoctorAdvice.Text = "医嘱";
            this.btn_DoctorAdvice.UseVisualStyleBackColor = true;
            // 
            // btn_CaseHistory
            // 
            this.btn_CaseHistory.Location = new System.Drawing.Point(155, 0);
            this.btn_CaseHistory.Name = "btn_CaseHistory";
            this.btn_CaseHistory.Size = new System.Drawing.Size(75, 23);
            this.btn_CaseHistory.TabIndex = 7;
            this.btn_CaseHistory.Text = "病例";
            this.btn_CaseHistory.UseVisualStyleBackColor = true;
            this.btn_CaseHistory.Click += new System.EventHandler(this.btn_CaseHistory_Click);
            // 
            // grp_CaseHistory
            // 
            this.grp_CaseHistory.Controls.Add(this.btn_Cancel);
            this.grp_CaseHistory.Controls.Add(this.btn_ShiftIn);
            this.grp_CaseHistory.Controls.Add(this.btn_ShiftOut);
            this.grp_CaseHistory.Controls.Add(this.btn_NewConstruction);
            this.grp_CaseHistory.Location = new System.Drawing.Point(227, 0);
            this.grp_CaseHistory.Name = "grp_CaseHistory";
            this.grp_CaseHistory.Size = new System.Drawing.Size(120, 82);
            this.grp_CaseHistory.TabIndex = 8;
            this.grp_CaseHistory.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(102, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(18, 18);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "✖";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_ShiftIn
            // 
            this.btn_ShiftIn.Location = new System.Drawing.Point(0, 41);
            this.btn_ShiftIn.Name = "btn_ShiftIn";
            this.btn_ShiftIn.Size = new System.Drawing.Size(75, 23);
            this.btn_ShiftIn.TabIndex = 2;
            this.btn_ShiftIn.Text = "移入";
            this.btn_ShiftIn.UseVisualStyleBackColor = true;
            // 
            // btn_ShiftOut
            // 
            this.btn_ShiftOut.Location = new System.Drawing.Point(0, 21);
            this.btn_ShiftOut.Name = "btn_ShiftOut";
            this.btn_ShiftOut.Size = new System.Drawing.Size(75, 23);
            this.btn_ShiftOut.TabIndex = 1;
            this.btn_ShiftOut.Text = "移出";
            this.btn_ShiftOut.UseVisualStyleBackColor = true;
            // 
            // btn_NewConstruction
            // 
            this.btn_NewConstruction.Location = new System.Drawing.Point(0, 0);
            this.btn_NewConstruction.Name = "btn_NewConstruction";
            this.btn_NewConstruction.Size = new System.Drawing.Size(75, 23);
            this.btn_NewConstruction.TabIndex = 0;
            this.btn_NewConstruction.Text = "新建";
            this.btn_NewConstruction.UseVisualStyleBackColor = true;
            this.btn_NewConstruction.Click += new System.EventHandler(this.btn_NewConstruction_Click);
            // 
            // lbl_UserMessage
            // 
            this.lbl_UserMessage.AutoSize = true;
            this.lbl_UserMessage.Location = new System.Drawing.Point(363, 3);
            this.lbl_UserMessage.Name = "lbl_UserMessage";
            this.lbl_UserMessage.Size = new System.Drawing.Size(95, 12);
            this.lbl_UserMessage.TabIndex = 9;
            this.lbl_UserMessage.Text = "lbl_UserMessage";
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(431, 0);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(39, 23);
            this.btn_Quit.TabIndex = 10;
            this.btn_Quit.Text = "退出";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // frm_WorkStationMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 413);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.lbl_UserMessage);
            this.Controls.Add(this.grp_CaseHistory);
            this.Controls.Add(this.btn_CaseHistory);
            this.Controls.Add(this.btn_DoctorAdvice);
            this.Controls.Add(this.btn_Temperature);
            this.Controls.Add(this.btn_HomePage);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.btn_Examine);
            this.Controls.Add(this.btn_DiseaseProgress);
            this.Controls.Add(this.dgv_Patient);
            this.Name = "frm_WorkStationMainPage";
            this.Text = "医生工作站主窗口";
            this.Load += new System.EventHandler(this.frm_WorkStationMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.grp_CaseHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Patient;
        private System.Windows.Forms.Button btn_DiseaseProgress;
        private System.Windows.Forms.Button btn_Examine;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Button btn_HomePage;
        private System.Windows.Forms.Button btn_Temperature;
        private System.Windows.Forms.Button btn_DoctorAdvice;
        private System.Windows.Forms.Button btn_CaseHistory;
        private System.Windows.Forms.GroupBox grp_CaseHistory;
        private System.Windows.Forms.Button btn_NewConstruction;
        private System.Windows.Forms.Button btn_ShiftIn;
        private System.Windows.Forms.Button btn_ShiftOut;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_UserMessage;
        private System.Windows.Forms.Button btn_Quit;
    }
}