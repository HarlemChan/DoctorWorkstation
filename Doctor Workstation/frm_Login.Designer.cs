namespace Doctor_Workstation
{
    partial class frm_Login
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
            this.lbl_LoginID = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txb_LoginID = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_LoginID
            // 
            this.lbl_LoginID.AutoSize = true;
            this.lbl_LoginID.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_LoginID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_LoginID.Location = new System.Drawing.Point(59, 72);
            this.lbl_LoginID.Name = "lbl_LoginID";
            this.lbl_LoginID.Size = new System.Drawing.Size(66, 19);
            this.lbl_LoginID.TabIndex = 0;
            this.lbl_LoginID.Text = "用户名";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Password.Location = new System.Drawing.Point(61, 140);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(57, 19);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "口 令";
            // 
            // txb_LoginID
            // 
            this.txb_LoginID.Location = new System.Drawing.Point(141, 70);
            this.txb_LoginID.Name = "txb_LoginID";
            this.txb_LoginID.Size = new System.Drawing.Size(151, 21);
            this.txb_LoginID.TabIndex = 2;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(141, 140);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(151, 21);
            this.txb_Password.TabIndex = 3;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(89, 209);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(62, 31);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "确定";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(252, 209);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(61, 31);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 292);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_LoginID);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_LoginID);
            this.Name = "frm_Login";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LoginID;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txb_LoginID;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
    }
}