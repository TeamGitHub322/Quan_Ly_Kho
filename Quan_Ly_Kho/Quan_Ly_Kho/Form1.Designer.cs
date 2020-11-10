namespace Quan_Ly_Kho
{
    partial class Form1
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
            this.textID = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.butLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butHuongDan = new System.Windows.Forms.Button();
            this.butQuanLyKho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(109, 15);
            this.textID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(154, 20);
            this.textID.TabIndex = 8;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(109, 43);
            this.textPass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(154, 20);
            this.textPass.TabIndex = 9;
            // 
            // butLogIn
            // 
            this.butLogIn.BackColor = System.Drawing.Color.Lime;
            this.butLogIn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogIn.Location = new System.Drawing.Point(73, 69);
            this.butLogIn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butLogIn.Name = "butLogIn";
            this.butLogIn.Size = new System.Drawing.Size(97, 33);
            this.butLogIn.TabIndex = 4;
            this.butLogIn.Text = "Đặng nhập";
            this.butLogIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // butLogOut
            // 
            this.butLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.butLogOut.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogOut.Location = new System.Drawing.Point(174, 69);
            this.butLogOut.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(89, 33);
            this.butLogOut.TabIndex = 5;
            this.butLogOut.Text = "Đăng xuất";
            this.butLogOut.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textID);
            this.panel1.Controls.Add(this.butLogOut);
            this.panel1.Controls.Add(this.textPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butLogIn);
            this.panel1.Location = new System.Drawing.Point(188, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 113);
            this.panel1.TabIndex = 10;
            // 
            // butHuongDan
            // 
            this.butHuongDan.Image = global::Quan_Ly_Kho.Properties.Resources.guide;
            this.butHuongDan.Location = new System.Drawing.Point(514, 139);
            this.butHuongDan.Name = "butHuongDan";
            this.butHuongDan.Size = new System.Drawing.Size(130, 130);
            this.butHuongDan.TabIndex = 11;
            this.butHuongDan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butHuongDan.UseVisualStyleBackColor = true;
            // 
            // butQuanLyKho
            // 
            this.butQuanLyKho.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuanLyKho.Image = global::Quan_Ly_Kho.Properties.Resources.Box;
            this.butQuanLyKho.Location = new System.Drawing.Point(33, 135);
            this.butQuanLyKho.Name = "butQuanLyKho";
            this.butQuanLyKho.Size = new System.Drawing.Size(130, 130);
            this.butQuanLyKho.TabIndex = 11;
            this.butQuanLyKho.Text = "Quản Lý Kho";
            this.butQuanLyKho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butQuanLyKho.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hướng dẫn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quan_Ly_Kho.Properties.Resources.KhoSITCDV2;
            this.ClientSize = new System.Drawing.Size(699, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butQuanLyKho);
            this.Controls.Add(this.butHuongDan);
            this.Controls.Add(this.panel1);
            this.Icon = global::Quan_Ly_Kho.Properties.Resources.icon;
            this.Name = "Form1";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button butLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butHuongDan;
        private System.Windows.Forms.Button butQuanLyKho;
        private System.Windows.Forms.Label label3;
    }
}

