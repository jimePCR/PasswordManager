﻿namespace PassMan
{
    partial class MainView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listAccounts = new System.Windows.Forms.DataGridView();
            this.NameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addAccount = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listAccounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAccounts
            // 
            this.listAccounts.AllowUserToAddRows = false;
            this.listAccounts.AllowUserToOrderColumns = true;
            this.listAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listAccounts.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.listAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameUser,
            this.Pass,
            this.Note,
            this.Edit,
            this.Delete});
            this.listAccounts.Location = new System.Drawing.Point(12, 144);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.ReadOnly = true;
            this.listAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listAccounts.Size = new System.Drawing.Size(994, 324);
            this.listAccounts.TabIndex = 1;
            this.listAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listAccounts_CellContentClick);
            // 
            // NameUser
            // 
            this.NameUser.FillWeight = 146.0974F;
            this.NameUser.HeaderText = "Name";
            this.NameUser.Name = "NameUser";
            this.NameUser.ReadOnly = true;
            // 
            // Pass
            // 
            this.Pass.FillWeight = 146.0974F;
            this.Pass.HeaderText = "Password";
            this.Pass.Name = "Pass";
            this.Pass.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.FillWeight = 146.0974F;
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "Edit";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.FillWeight = 31.25079F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "Delete";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FillWeight = 30.45685F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Passwords";
            // 
            // addAccount
            // 
            this.addAccount.Location = new System.Drawing.Point(12, 106);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(75, 23);
            this.addAccount.TabIndex = 2;
            this.addAccount.Text = "Add";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // showPass
            // 
            this.showPass.Location = new System.Drawing.Point(107, 106);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(110, 23);
            this.showPass.TabIndex = 3;
            this.showPass.Text = "Show Passwords";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 480);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.listAccounts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainView";
            this.Text = "MainView";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listAccounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addAccount;
        private System.Windows.Forms.Button showPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}