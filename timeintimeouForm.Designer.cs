namespace TimeInTimeOutwithMSSQL
{
    partial class timeintimeouForm
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
            this.timeinBtn = new Guna.UI2.WinForms.Guna2Button();
            this.timeinTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeoutTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.timeoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.employeenoLbl = new System.Windows.Forms.Label();
            this.employeenoTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totaltimeTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeinBtn
            // 
            this.timeinBtn.AutoRoundedCorners = true;
            this.timeinBtn.BorderRadius = 17;
            this.timeinBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.timeinBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.timeinBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.timeinBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.timeinBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.timeinBtn.ForeColor = System.Drawing.Color.White;
            this.timeinBtn.Location = new System.Drawing.Point(33, 99);
            this.timeinBtn.Name = "timeinBtn";
            this.timeinBtn.Size = new System.Drawing.Size(93, 36);
            this.timeinBtn.TabIndex = 3;
            this.timeinBtn.Text = "Time In";
            this.timeinBtn.Click += new System.EventHandler(this.timeinBtn_Click);
            // 
            // timeinTxt
            // 
            this.timeinTxt.BorderRadius = 5;
            this.timeinTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeinTxt.DefaultText = "";
            this.timeinTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeinTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeinTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeinTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeinTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeinTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeinTxt.ForeColor = System.Drawing.Color.Black;
            this.timeinTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeinTxt.Location = new System.Drawing.Point(142, 102);
            this.timeinTxt.Name = "timeinTxt";
            this.timeinTxt.PasswordChar = '\0';
            this.timeinTxt.PlaceholderText = "";
            this.timeinTxt.ReadOnly = true;
            this.timeinTxt.SelectedText = "";
            this.timeinTxt.Size = new System.Drawing.Size(167, 30);
            this.timeinTxt.TabIndex = 0;
            this.timeinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeoutTxt
            // 
            this.timeoutTxt.BorderRadius = 5;
            this.timeoutTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeoutTxt.DefaultText = "";
            this.timeoutTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeoutTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeoutTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeoutTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeoutTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeoutTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeoutTxt.ForeColor = System.Drawing.Color.Black;
            this.timeoutTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timeoutTxt.Location = new System.Drawing.Point(142, 144);
            this.timeoutTxt.Name = "timeoutTxt";
            this.timeoutTxt.PasswordChar = '\0';
            this.timeoutTxt.PlaceholderText = "";
            this.timeoutTxt.ReadOnly = true;
            this.timeoutTxt.SelectedText = "";
            this.timeoutTxt.Size = new System.Drawing.Size(167, 30);
            this.timeoutTxt.TabIndex = 0;
            this.timeoutTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeoutBtn
            // 
            this.timeoutBtn.AutoRoundedCorners = true;
            this.timeoutBtn.BorderRadius = 17;
            this.timeoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.timeoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.timeoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.timeoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.timeoutBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.timeoutBtn.ForeColor = System.Drawing.Color.White;
            this.timeoutBtn.Location = new System.Drawing.Point(33, 141);
            this.timeoutBtn.Name = "timeoutBtn";
            this.timeoutBtn.Size = new System.Drawing.Size(93, 36);
            this.timeoutBtn.TabIndex = 4;
            this.timeoutBtn.Text = "Time Out";
            this.timeoutBtn.Click += new System.EventHandler(this.timeoutBtn_Click);
            // 
            // nameTxt
            // 
            this.nameTxt.BorderRadius = 5;
            this.nameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTxt.DefaultText = "";
            this.nameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTxt.ForeColor = System.Drawing.Color.Black;
            this.nameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTxt.Location = new System.Drawing.Point(142, 60);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PlaceholderText = "";
            this.nameTxt.SelectedText = "";
            this.nameTxt.Size = new System.Drawing.Size(167, 30);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(54, 63);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(62, 23);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "Name:";
            // 
            // employeenoLbl
            // 
            this.employeenoLbl.AutoSize = true;
            this.employeenoLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeenoLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeenoLbl.Location = new System.Drawing.Point(16, 23);
            this.employeenoLbl.Name = "employeenoLbl";
            this.employeenoLbl.Size = new System.Drawing.Size(120, 23);
            this.employeenoLbl.TabIndex = 7;
            this.employeenoLbl.Text = "Employee No:";
            // 
            // employeenoTxt
            // 
            this.employeenoTxt.BorderRadius = 5;
            this.employeenoTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employeenoTxt.DefaultText = "";
            this.employeenoTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employeenoTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employeenoTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeenoTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employeenoTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeenoTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.employeenoTxt.ForeColor = System.Drawing.Color.Black;
            this.employeenoTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employeenoTxt.Location = new System.Drawing.Point(142, 18);
            this.employeenoTxt.Name = "employeenoTxt";
            this.employeenoTxt.PasswordChar = '\0';
            this.employeenoTxt.PlaceholderText = "";
            this.employeenoTxt.SelectedText = "";
            this.employeenoTxt.Size = new System.Drawing.Size(167, 30);
            this.employeenoTxt.TabIndex = 1;
            this.employeenoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.employeenoTxt.TextChanged += new System.EventHandler(this.employeenoTxt_TextChanged);
            this.employeenoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeenoTxt_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Green;
            this.addBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addBtn.Location = new System.Drawing.Point(45, 231);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 39);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Time:";
            // 
            // totaltimeTxt
            // 
            this.totaltimeTxt.BorderRadius = 5;
            this.totaltimeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totaltimeTxt.DefaultText = "";
            this.totaltimeTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totaltimeTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totaltimeTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totaltimeTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totaltimeTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totaltimeTxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totaltimeTxt.ForeColor = System.Drawing.Color.Black;
            this.totaltimeTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totaltimeTxt.Location = new System.Drawing.Point(142, 186);
            this.totaltimeTxt.Name = "totaltimeTxt";
            this.totaltimeTxt.PasswordChar = '\0';
            this.totaltimeTxt.PlaceholderText = "";
            this.totaltimeTxt.ReadOnly = true;
            this.totaltimeTxt.SelectedText = "";
            this.totaltimeTxt.Size = new System.Drawing.Size(167, 30);
            this.totaltimeTxt.TabIndex = 5;
            this.totaltimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.Yellow;
            this.editBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editBtn.Location = new System.Drawing.Point(131, 231);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(80, 39);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "Update";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteBtn.Location = new System.Drawing.Point(217, 231);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(80, 39);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // timeintimeouForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(338, 282);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totaltimeTxt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.employeenoLbl);
            this.Controls.Add(this.employeenoTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.timeoutTxt);
            this.Controls.Add(this.timeoutBtn);
            this.Controls.Add(this.timeinTxt);
            this.Controls.Add(this.timeinBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "timeintimeouForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time In Time Out";
            this.Load += new System.EventHandler(this.timeintimeouForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button timeinBtn;
        private Guna.UI2.WinForms.Guna2TextBox timeinTxt;
        private Guna.UI2.WinForms.Guna2TextBox timeoutTxt;
        private Guna.UI2.WinForms.Guna2Button timeoutBtn;
        private Guna.UI2.WinForms.Guna2TextBox nameTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label employeenoLbl;
        private Guna.UI2.WinForms.Guna2TextBox employeenoTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox totaltimeTxt;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}

