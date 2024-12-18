namespace PassMan.Views
{
    partial class EditAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.cancelAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.passValue = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.userValue = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Account";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(17, 214);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(241, 73);
            this.notes.TabIndex = 29;
            this.notes.Text = "";
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(107, 350);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(151, 23);
            this.savebtn.TabIndex = 28;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // cancelAcc
            // 
            this.cancelAcc.BackColor = System.Drawing.Color.Transparent;
            this.cancelAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelAcc.ForeColor = System.Drawing.Color.Black;
            this.cancelAcc.Location = new System.Drawing.Point(17, 350);
            this.cancelAcc.Name = "cancelAcc";
            this.cancelAcc.Size = new System.Drawing.Size(83, 23);
            this.cancelAcc.TabIndex = 27;
            this.cancelAcc.Text = "Cancel";
            this.cancelAcc.UseVisualStyleBackColor = false;
            this.cancelAcc.Click += new System.EventHandler(this.cancelAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(14, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Notes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(17, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 2);
            this.panel3.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password";
            // 
            // passValue
            // 
            this.passValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.passValue.Location = new System.Drawing.Point(17, 148);
            this.passValue.Multiline = true;
            this.passValue.Name = "passValue";
            this.passValue.PasswordChar = '*';
            this.passValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.passValue.Size = new System.Drawing.Size(241, 24);
            this.passValue.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(17, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 2);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "User";
            // 
            // userValue
            // 
            this.userValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.userValue.Location = new System.Drawing.Point(17, 77);
            this.userValue.Multiline = true;
            this.userValue.Name = "userValue";
            this.userValue.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.userValue.Size = new System.Drawing.Size(241, 24);
            this.userValue.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(17, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 2);
            this.panel1.TabIndex = 19;
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 402);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.cancelAcc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passValue);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userValue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button cancelAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userValue;
        private System.Windows.Forms.Panel panel1;
    }
}