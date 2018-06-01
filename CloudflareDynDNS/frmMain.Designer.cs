﻿namespace CloudflareDynDNS
{
	partial class frmMain
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
			this.btnGo = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.btnQuit = new System.Windows.Forms.Button();
			this.lblExternalAddress = new System.Windows.Forms.Label();
			this.txtExternalAddress = new System.Windows.Forms.TextBox();
			this.listViewRecords = new System.Windows.Forms.ListView();
			this.colUpdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnSettings = new System.Windows.Forms.Button();
			this.btnUpdateDNS = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(53, 619);
			this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(131, 41);
			this.btnGo.TabIndex = 0;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(15, 334);
			this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(772, 264);
			this.txtOutput.TabIndex = 1;
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(617, 619);
			this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(131, 41);
			this.btnQuit.TabIndex = 2;
			this.btnQuit.Text = "Quit";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
			// 
			// lblExternalAddress
			// 
			this.lblExternalAddress.AutoSize = true;
			this.lblExternalAddress.Location = new System.Drawing.Point(11, 16);
			this.lblExternalAddress.Name = "lblExternalAddress";
			this.lblExternalAddress.Size = new System.Drawing.Size(119, 20);
			this.lblExternalAddress.TabIndex = 3;
			this.lblExternalAddress.Text = "External Address";
			// 
			// txtExternalAddress
			// 
			this.txtExternalAddress.Location = new System.Drawing.Point(110, 14);
			this.txtExternalAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtExternalAddress.Name = "txtExternalAddress";
			this.txtExternalAddress.ReadOnly = true;
			this.txtExternalAddress.Size = new System.Drawing.Size(150, 27);
			this.txtExternalAddress.TabIndex = 4;
			// 
			// listViewRecords
			// 
			this.listViewRecords.CheckBoxes = true;
			this.listViewRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUpdate,
            this.colName,
            this.colAddress});
			this.listViewRecords.Location = new System.Drawing.Point(15, 49);
			this.listViewRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listViewRecords.Name = "listViewRecords";
			this.listViewRecords.Size = new System.Drawing.Size(772, 278);
			this.listViewRecords.TabIndex = 5;
			this.listViewRecords.UseCompatibleStateImageBehavior = false;
			this.listViewRecords.View = System.Windows.Forms.View.Details;
			this.listViewRecords.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewRecords_ItemChecked);
			// 
			// colUpdate
			// 
			this.colUpdate.Text = "Update";
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 127;
			// 
			// colAddress
			// 
			this.colAddress.Text = "Address";
			this.colAddress.Width = 300;
			// 
			// btnSettings
			// 
			this.btnSettings.Location = new System.Drawing.Point(241, 619);
			this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(131, 41);
			this.btnSettings.TabIndex = 6;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// btnUpdateDNS
			// 
			this.btnUpdateDNS.Location = new System.Drawing.Point(429, 619);
			this.btnUpdateDNS.Name = "btnUpdateDNS";
			this.btnUpdateDNS.Size = new System.Drawing.Size(131, 41);
			this.btnUpdateDNS.TabIndex = 7;
			this.btnUpdateDNS.Text = "Update DNS";
			this.btnUpdateDNS.UseVisualStyleBackColor = true;
			this.btnUpdateDNS.Click += new System.EventHandler(this.btnUpdateDNS_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 678);
			this.Controls.Add(this.btnUpdateDNS);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.listViewRecords);
			this.Controls.Add(this.txtExternalAddress);
			this.Controls.Add(this.lblExternalAddress);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnGo);
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cloudflare DynDNS";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Label lblExternalAddress;
		private System.Windows.Forms.TextBox txtExternalAddress;
		private System.Windows.Forms.ListView listViewRecords;
		private System.Windows.Forms.ColumnHeader colUpdate;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colAddress;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.Button btnUpdateDNS;
	}
}
