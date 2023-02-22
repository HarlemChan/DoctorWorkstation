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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Patient
            // 
            this.dgv_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Patient.Location = new System.Drawing.Point(1, 0);
            this.dgv_Patient.Name = "dgv_Patient";
            this.dgv_Patient.RowTemplate.Height = 23;
            this.dgv_Patient.Size = new System.Drawing.Size(240, 411);
            this.dgv_Patient.TabIndex = 0;
            // 
            // frm_WorkStationMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 413);
            this.Controls.Add(this.dgv_Patient);
            this.Name = "frm_WorkStationMainPage";
            this.Text = "医生工作站主窗口";
            this.Load += new System.EventHandler(this.frm_WorkStationMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Patient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Patient;
    }
}