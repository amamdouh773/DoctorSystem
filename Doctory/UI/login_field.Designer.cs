namespace Doctory.UI
{
    partial class login_field
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_field));
            this.label1 = new System.Windows.Forms.Label();
            this.username_fld = new System.Windows.Forms.TextBox();
            this.w = new System.Windows.Forms.Label();
            this.userpassword_fld = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "USERNAME";
            // 
            // username_fld
            // 
            this.username_fld.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_fld.Location = new System.Drawing.Point(551, 197);
            this.username_fld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_fld.Name = "username_fld";
            this.username_fld.Size = new System.Drawing.Size(461, 34);
            this.username_fld.TabIndex = 1;
            this.username_fld.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w.Location = new System.Drawing.Point(665, 272);
            this.w.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(225, 37);
            this.w.TabIndex = 2;
            this.w.Text = "USER PASSWORD";
            // 
            // userpassword_fld
            // 
            this.userpassword_fld.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpassword_fld.Location = new System.Drawing.Point(551, 313);
            this.userpassword_fld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userpassword_fld.Name = "userpassword_fld";
            this.userpassword_fld.PasswordChar = '*';
            this.userpassword_fld.Size = new System.Drawing.Size(461, 34);
            this.userpassword_fld.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Location = new System.Drawing.Point(686, 377);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(224, 37);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "LogIn";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "D O C T O R Y";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Doctory.Properties.Resources.icons8_medical_doctor_50;
            this.pictureBox2.Location = new System.Drawing.Point(127, 197);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1153, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login_field
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 561);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userpassword_fld);
            this.Controls.Add(this.w);
            this.Controls.Add(this.username_fld);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login_field";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login_field";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_field_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_field_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_fld;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.TextBox userpassword_fld;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}