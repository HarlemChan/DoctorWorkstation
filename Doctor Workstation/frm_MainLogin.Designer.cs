namespace Doctor_Workstation
{
    partial class frm_MainLogin
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_MainLogin = new System.Windows.Forms.Button();
            this.lbl_VisionName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Title.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl_Title.Location = new System.Drawing.Point(170, 45);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(156, 27);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "医院信息系统";
            // 
            // btn_MainLogin
            // 
            this.btn_MainLogin.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_MainLogin.ForeColor = System.Drawing.Color.Blue;
            this.btn_MainLogin.Location = new System.Drawing.Point(100, 95);
            this.btn_MainLogin.Name = "btn_MainLogin";
            this.btn_MainLogin.Size = new System.Drawing.Size(298, 51);
            this.btn_MainLogin.TabIndex = 1;
            this.btn_MainLogin.Text = "医生工作站";
            this.btn_MainLogin.UseVisualStyleBackColor = true;
            this.btn_MainLogin.Click += new System.EventHandler(this.btn_MainLogin_Click);
            // 
            // lbl_VisionName
            // 
            this.lbl_VisionName.AutoSize = true;
            this.lbl_VisionName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_VisionName.ForeColor = System.Drawing.Color.Blue;
            this.lbl_VisionName.Location = new System.Drawing.Point(227, 175);
            this.lbl_VisionName.Name = "lbl_VisionName";
            this.lbl_VisionName.Size = new System.Drawing.Size(63, 16);
            this.lbl_VisionName.TabIndex = 2;
            this.lbl_VisionName.Text = "开发ing";
            // 
            // frm_MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 311);
            this.Controls.Add(this.lbl_VisionName);
            this.Controls.Add(this.btn_MainLogin);
            this.Controls.Add(this.lbl_Title);
            this.Name = "frm_MainLogin";
            this.Text = "医生工作站入口";
            this.Load += new System.EventHandler(this.frm_MainLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_MainLogin;
        private System.Windows.Forms.Label lbl_VisionName;
    }
}