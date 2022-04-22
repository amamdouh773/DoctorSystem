namespace ADMIN_PAGE_hospital
{
    partial class admin_page
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
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.dgvdoctor = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.pnlground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtspecialisty = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.docpass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtaffilation = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.LimeGreen;
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(63, 77);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(103, 22);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Doctor Name";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.LimeGreen;
            this.lbladdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(67, 353);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(124, 25);
            this.lbladdress.TabIndex = 1;
            this.lbladdress.Text = "DoctorAddress";
            this.lbladdress.Click += new System.EventHandler(this.lbladdress_Click);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.BackColor = System.Drawing.Color.LimeGreen;
            this.lblphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblphone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(63, 275);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(118, 25);
            this.lblphone.TabIndex = 2;
            this.lblphone.Text = "Doctor Phone";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(227, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(269, 22);
            this.txtname.TabIndex = 3;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(227, 355);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(269, 32);
            this.txtaddress.TabIndex = 4;
            this.txtaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(227, 278);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(269, 22);
            this.txtphone.TabIndex = 5;
            // 
            // dgvdoctor
            // 
            this.dgvdoctor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvdoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdoctor.Location = new System.Drawing.Point(590, 42);
            this.dgvdoctor.Name = "dgvdoctor";
            this.dgvdoctor.RowHeadersWidth = 51;
            this.dgvdoctor.RowTemplate.Height = 24;
            this.dgvdoctor.Size = new System.Drawing.Size(500, 286);
            this.dgvdoctor.TabIndex = 6;
            this.dgvdoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdoctor_CellContentClick);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.YellowGreen;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(660, 372);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(121, 48);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.YellowGreen;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(891, 372);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(121, 48);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pnlground
            // 
            this.pnlground.BackColor = System.Drawing.Color.PaleGreen;
            this.pnlground.Location = new System.Drawing.Point(0, 651);
            this.pnlground.Name = "pnlground";
            this.pnlground.Size = new System.Drawing.Size(1111, 58);
            this.pnlground.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Doctor_specialisty";
            // 
            // txtspecialisty
            // 
            this.txtspecialisty.Location = new System.Drawing.Point(233, 516);
            this.txtspecialisty.Name = "txtspecialisty";
            this.txtspecialisty.Size = new System.Drawing.Size(269, 22);
            this.txtspecialisty.TabIndex = 14;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(233, 435);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(269, 22);
            this.txtpass.TabIndex = 13;
            this.txtpass.Text = "1234";
            // 
            // docpass
            // 
            this.docpass.AutoSize = true;
            this.docpass.BackColor = System.Drawing.Color.LimeGreen;
            this.docpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.docpass.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docpass.Location = new System.Drawing.Point(63, 435);
            this.docpass.Name = "docpass";
            this.docpass.Size = new System.Drawing.Size(143, 25);
            this.docpass.TabIndex = 12;
            this.docpass.Text = "Doctor_password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LimeGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 595);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Doctor_affiliation";
            // 
            // txtaffilation
            // 
            this.txtaffilation.Location = new System.Drawing.Point(233, 595);
            this.txtaffilation.Name = "txtaffilation";
            this.txtaffilation.Size = new System.Drawing.Size(269, 22);
            this.txtaffilation.TabIndex = 17;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.BackColor = System.Drawing.Color.LimeGreen;
            this.lbllastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(63, 205);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(82, 22);
            this.lbllastname.TabIndex = 18;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.Color.LimeGreen;
            this.lblfirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(63, 141);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(85, 22);
            this.lblfirstname.TabIndex = 19;
            this.lblfirstname.Text = "First Name";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(227, 141);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(269, 22);
            this.txtfirstname.TabIndex = 22;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(227, 205);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(269, 22);
            this.txtlastname.TabIndex = 23;
            // 
            // admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1102, 710);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.txtaffilation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtspecialisty);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.docpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlground);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dgvdoctor);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblname);
            this.Name = "admin_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.admin_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.DataGridView dgvdoctor;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Panel pnlground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtspecialisty;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label docpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtaffilation;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
    }
}

