﻿namespace Quan_Ly_Kho.HuongDan
{
     partial class Help
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
               System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nhóm Thực Hiện");
               System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sản Phẩm");
               System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Giới Thiệu Chung", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
               System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quản Lý Chung");
               System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hàng Hóa");
               System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Phiếu Mượn");
               System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nhà Cung Cấp");
               System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hướng Dẫn", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
               this.webBrowser1 = new System.Windows.Forms.WebBrowser();
               this.treeView1 = new System.Windows.Forms.TreeView();
               this.SuspendLayout();
               // 
               // webBrowser1
               // 
               this.webBrowser1.Location = new System.Drawing.Point(195, 11);
               this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 19);
               this.webBrowser1.Name = "webBrowser1";
               this.webBrowser1.Size = new System.Drawing.Size(827, 498);
               this.webBrowser1.TabIndex = 3;
               // 
               // treeView1
               // 
               this.treeView1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
               this.treeView1.Location = new System.Drawing.Point(3, 11);
               this.treeView1.Name = "treeView1";
               treeNode1.Name = "GT_NTH";
               treeNode1.Text = "Nhóm Thực Hiện";
               treeNode2.Name = "GT_SP";
               treeNode2.Text = "Sản Phẩm";
               treeNode3.Name = "GT";
               treeNode3.Text = "Giới Thiệu Chung";
               treeNode4.Name = "HD_QLC";
               treeNode4.Text = "Quản Lý Chung";
               treeNode5.Name = "HD_HH";
               treeNode5.Text = "Hàng Hóa";
               treeNode6.Name = "HD_PM";
               treeNode6.Text = "Phiếu Mượn";
               treeNode7.Name = "HD_NCC";
               treeNode7.Text = "Nhà Cung Cấp";
               treeNode8.Name = "HD";
               treeNode8.Text = "Hướng Dẫn";
               this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8});
               this.treeView1.Size = new System.Drawing.Size(185, 498);
               this.treeView1.TabIndex = 2;
               this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
               // 
               // Help
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1034, 521);
               this.Controls.Add(this.webBrowser1);
               this.Controls.Add(this.treeView1);
               this.Name = "Help";
               this.Text = "Help";
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.WebBrowser webBrowser1;
          private System.Windows.Forms.TreeView treeView1;
     }
}