﻿namespace SnapChat
{
    partial class frmGiaoDien
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
            this.components = new System.ComponentModel.Container();
            this.listViewdanhsach = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_khungchat = new System.Windows.Forms.ListView();
            this.txt_tinnhan = new System.Windows.Forms.TextBox();
            this.btn_gui = new System.Windows.Forms.Button();
            this.loadeventListFriend = new System.Windows.Forms.Timer(this.components);
            this.lb_Sender = new System.Windows.Forms.Label();
            this.loadeventLKhungChat = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuChucnang = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_clock = new System.Windows.Forms.PictureBox();
            this.menuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clock)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewdanhsach
            // 
            this.listViewdanhsach.BackColor = System.Drawing.Color.MediumOrchid;
            this.listViewdanhsach.BackgroundImage = global::SnapChat.Properties.Resources.Icon3;
            this.listViewdanhsach.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewdanhsach.Location = new System.Drawing.Point(427, 45);
            this.listViewdanhsach.Name = "listViewdanhsach";
            this.listViewdanhsach.Size = new System.Drawing.Size(146, 271);
            this.listViewdanhsach.TabIndex = 0;
            this.listViewdanhsach.UseCompatibleStateImageBehavior = false;
            this.listViewdanhsach.SelectedIndexChanged += new System.EventHandler(this.listViewdanhsach_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách chat";
            // 
            // listView_khungchat
            // 
            this.listView_khungchat.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_khungchat.BackColor = System.Drawing.Color.Violet;
            this.listView_khungchat.BackgroundImage = global::SnapChat.Properties.Resources.Icon3;
            this.listView_khungchat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_khungchat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listView_khungchat.Location = new System.Drawing.Point(25, 35);
            this.listView_khungchat.MultiSelect = false;
            this.listView_khungchat.Name = "listView_khungchat";
            this.listView_khungchat.Size = new System.Drawing.Size(348, 189);
            this.listView_khungchat.TabIndex = 2;
            this.listView_khungchat.UseCompatibleStateImageBehavior = false;
            this.listView_khungchat.View = System.Windows.Forms.View.Details;
            // 
            // txt_tinnhan
            // 
            this.txt_tinnhan.BackColor = System.Drawing.Color.MediumOrchid;
            this.txt_tinnhan.Enabled = false;
            this.txt_tinnhan.Location = new System.Drawing.Point(25, 259);
            this.txt_tinnhan.Multiline = true;
            this.txt_tinnhan.Name = "txt_tinnhan";
            this.txt_tinnhan.Size = new System.Drawing.Size(278, 54);
            this.txt_tinnhan.TabIndex = 3;
            // 
            // btn_gui
            // 
            this.btn_gui.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_gui.Location = new System.Drawing.Point(309, 259);
            this.btn_gui.Name = "btn_gui";
            this.btn_gui.Size = new System.Drawing.Size(64, 54);
            this.btn_gui.TabIndex = 4;
            this.btn_gui.Text = "Gửi";
            this.btn_gui.UseVisualStyleBackColor = false;
            this.btn_gui.Click += new System.EventHandler(this.btn_gui_Click);
            // 
            // loadeventListFriend
            // 
            this.loadeventListFriend.Interval = 10000;
            this.loadeventListFriend.Tick += new System.EventHandler(this.loadeventListFriend_Tick);
            // 
            // lb_Sender
            // 
            this.lb_Sender.AutoSize = true;
            this.lb_Sender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Sender.ForeColor = System.Drawing.Color.Red;
            this.lb_Sender.Location = new System.Drawing.Point(25, 241);
            this.lb_Sender.Name = "lb_Sender";
            this.lb_Sender.Size = new System.Drawing.Size(46, 15);
            this.lb_Sender.TabIndex = 5;
            this.lb_Sender.Text = "Sender:";
            this.lb_Sender.TextChanged += new System.EventHandler(this.lb_Sender_TextChanged);
            // 
            // loadeventLKhungChat
            // 
            this.loadeventLKhungChat.Tick += new System.EventHandler(this.loadeventLKhungChat_Tick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DarkViolet;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuChucnang,
            this.menuDangxuat});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(606, 24);
            this.menu.TabIndex = 6;
            this.menu.Text = "menuStrip1";
            // 
            // menuChucnang
            // 
            this.menuChucnang.Name = "menuChucnang";
            this.menuChucnang.Size = new System.Drawing.Size(79, 20);
            this.menuChucnang.Text = "Chức Năng";
            // 
            // pictureBox_clock
            // 
            this.pictureBox_clock.Image = global::SnapChat.Properties.Resources.clock;
            this.pictureBox_clock.Location = new System.Drawing.Point(79, 240);
            this.pictureBox_clock.Name = "pictureBox_clock";
            this.pictureBox_clock.Size = new System.Drawing.Size(14, 15);
            this.pictureBox_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_clock.TabIndex = 7;
            this.pictureBox_clock.TabStop = false;
            this.pictureBox_clock.Click += new System.EventHandler(this.pictureBox_clock_Click);
            // 
            // menuDangxuat
            // 
            this.menuDangxuat.Name = "menuDangxuat";
            this.menuDangxuat.Size = new System.Drawing.Size(72, 20);
            this.menuDangxuat.Text = "Đăng xuất";
            this.menuDangxuat.Click += new System.EventHandler(this.menuDangxuat_Click);
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnapChat.Properties.Resources.Icon1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 337);
            this.Controls.Add(this.pictureBox_clock);
            this.Controls.Add(this.lb_Sender);
            this.Controls.Add(this.btn_gui);
            this.Controls.Add(this.txt_tinnhan);
            this.Controls.Add(this.listView_khungchat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewdanhsach);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "frmGiaoDien";
            this.Text = "GiaoDien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoDien_FormClosing);
            this.Load += new System.EventHandler(this.frmGiaoDien_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewdanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_khungchat;
        private System.Windows.Forms.TextBox txt_tinnhan;
        private System.Windows.Forms.Button btn_gui;
        private System.Windows.Forms.Timer loadeventListFriend;
        private System.Windows.Forms.Label lb_Sender;
        private System.Windows.Forms.Timer loadeventLKhungChat;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuChucnang;
        private System.Windows.Forms.PictureBox pictureBox_clock;
        private System.Windows.Forms.ToolStripMenuItem menuDangxuat;
    }
}