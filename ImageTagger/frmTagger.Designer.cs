﻿namespace ImageTagger
{
	partial class frmTagger
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
			this.lst = new System.Windows.Forms.ListView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.txtPath = new System.Windows.Forms.TextBox();
			this.buttonLoad = new System.Windows.Forms.Button();
			this.panelTop = new System.Windows.Forms.Panel();
			this.btnPickPath = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.panelRight = new System.Windows.Forms.FlowLayoutPanel();
			this.panelTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// lst
			// 
			this.lst.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lst.GridLines = true;
			this.lst.HideSelection = false;
			this.lst.LabelWrap = false;
			this.lst.LargeImageList = this.imageList;
			this.lst.Location = new System.Drawing.Point(0, 27);
			this.lst.Name = "lst";
			this.lst.ShowGroups = false;
			this.lst.Size = new System.Drawing.Size(918, 654);
			this.lst.TabIndex = 0;
			this.lst.TileSize = new System.Drawing.Size(128, 128);
			this.lst.UseCompatibleStateImageBehavior = false;
			this.lst.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lst_ItemSelectionChanged);
			this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
			this.lst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_KeyDown);
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList.ImageSize = new System.Drawing.Size(128, 128);
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(3, 3);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(393, 20);
			this.txtPath.TabIndex = 0;
			this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
			// 
			// buttonLoad
			// 
			this.buttonLoad.Location = new System.Drawing.Point(449, 3);
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.Size = new System.Drawing.Size(41, 20);
			this.buttonLoad.TabIndex = 2;
			this.buttonLoad.Text = "Load";
			this.buttonLoad.UseVisualStyleBackColor = true;
			this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.btnPickPath);
			this.panelTop.Controls.Add(this.buttonSave);
			this.panelTop.Controls.Add(this.txtPath);
			this.panelTop.Controls.Add(this.buttonLoad);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(918, 27);
			this.panelTop.TabIndex = 3;
			// 
			// btnPickPath
			// 
			this.btnPickPath.Location = new System.Drawing.Point(402, 3);
			this.btnPickPath.Name = "btnPickPath";
			this.btnPickPath.Size = new System.Drawing.Size(41, 20);
			this.btnPickPath.TabIndex = 1;
			this.btnPickPath.Text = "...";
			this.btnPickPath.UseVisualStyleBackColor = true;
			this.btnPickPath.Click += new System.EventHandler(this.btnPickPath_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(496, 4);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(41, 20);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// panelRight
			// 
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelRight.Location = new System.Drawing.Point(918, 0);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(258, 681);
			this.panelRight.TabIndex = 4;
			this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
			// 
			// frmTagger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1176, 681);
			this.Controls.Add(this.lst);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.panelRight);
			this.Name = "frmTagger";
			this.Text = "ImageTagger";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTagger_FormClosing);
			this.Load += new System.EventHandler(this.frmTagger_Load);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lst;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button buttonLoad;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.FlowLayoutPanel panelRight;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button btnPickPath;
	}
}

