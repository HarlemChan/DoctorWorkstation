namespace Doctor_Workstation
{
    partial class frm_CaseHistoryShiftIn
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
            this.dgv_ShiftInPatient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShiftInPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ShiftInPatient
            // 
            this.dgv_ShiftInPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShiftInPatient.Location = new System.Drawing.Point(0, -3);
            this.dgv_ShiftInPatient.Name = "dgv_ShiftInPatient";
            this.dgv_ShiftInPatient.RowTemplate.Height = 23;
            this.dgv_ShiftInPatient.Size = new System.Drawing.Size(214, 294);
            this.dgv_ShiftInPatient.TabIndex = 0;
            // 
            // frm_CaseHistoryShiftIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 290);
            this.Controls.Add(this.dgv_ShiftInPatient);
            this.Name = "frm_CaseHistoryShiftIn";
            this.Text = "移入";
            this.Load += new System.EventHandler(this.frm_CaseHistoryShiftIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShiftInPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ShiftInPatient;
    }
}