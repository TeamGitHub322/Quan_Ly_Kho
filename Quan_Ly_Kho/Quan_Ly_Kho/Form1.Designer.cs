﻿namespace Quan_Ly_Kho
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
            this.butHuongDan = new System.Windows.Forms.Button();
            this.butQuanLyKho = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butHuongDan
            // 
            this.butHuongDan.Image = global::Quan_Ly_Kho.Properties.Resources.guide;
            this.butHuongDan.Location = new System.Drawing.Point(439, 139);
            this.butHuongDan.Name = "butHuongDan";
            this.butHuongDan.Size = new System.Drawing.Size(130, 130);
            this.butHuongDan.TabIndex = 11;
            this.butHuongDan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butHuongDan.UseVisualStyleBackColor = true;
            this.butHuongDan.Click += new System.EventHandler(this.ButHuongDan_Click_1);
            // 
            // butQuanLyKho
            // 
            this.butQuanLyKho.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuanLyKho.Image = global::Quan_Ly_Kho.Properties.Resources.Box;
            this.butQuanLyKho.Location = new System.Drawing.Point(101, 139);
            this.butQuanLyKho.Name = "butQuanLyKho";
            this.butQuanLyKho.Size = new System.Drawing.Size(130, 130);
            this.butQuanLyKho.TabIndex = 11;
            this.butQuanLyKho.Text = "Quản Lý Kho";
            this.butQuanLyKho.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butQuanLyKho.UseVisualStyleBackColor = true;
            this.butQuanLyKho.Click += new System.EventHandler(this.ButQuanLyKho_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 145);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(778, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butQuanLyKho);
            this.Controls.Add(this.butHuongDan);
            this.Icon = global::Quan_Ly_Kho.Properties.Resources.icon;
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butHuongDan;
        private System.Windows.Forms.Button butQuanLyKho;
        private System.Windows.Forms.Label label3;
    }
}

