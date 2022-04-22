namespace Doctory.UI
{
    partial class Patient_profile_module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_profile_module));
            this.main_panel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.Reservation_btn = new System.Windows.Forms.Button();
            this.My_profile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_field = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.username_profile = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.password_fld = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descrip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id_fld = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.main_panel.Controls.Add(this.pictureBox3);
            this.main_panel.Controls.Add(this.pictureBox2);
            this.main_panel.Controls.Add(this.close);
            this.main_panel.Controls.Add(this.Reservation_btn);
            this.main_panel.Controls.Add(this.My_profile);
            resources.ApplyResources(this.main_panel, "main_panel");
            this.main_panel.Name = "main_panel";
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.main_panel_Paint);
            this.main_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.main_panel_MouseClick);
            this.main_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.main_panel_MouseDown);
            this.main_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_panel_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Doctory.Properties.Resources.left_arrow;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Doctory.Properties.Resources.log_out;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Reservation_btn
            // 
            this.Reservation_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Reservation_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reservation_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Reservation_btn, "Reservation_btn");
            this.Reservation_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reservation_btn.Name = "Reservation_btn";
            this.Reservation_btn.UseVisualStyleBackColor = false;
            this.Reservation_btn.Click += new System.EventHandler(this.Reservation_btn_Click);
            // 
            // My_profile
            // 
            this.My_profile.BackColor = System.Drawing.Color.ForestGreen;
            this.My_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.My_profile.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.My_profile, "My_profile");
            this.My_profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.My_profile.Name = "My_profile";
            this.My_profile.UseVisualStyleBackColor = false;
            this.My_profile.Click += new System.EventHandler(this.My_profile_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // first_name
            // 
            this.first_name.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.first_name, "first_name");
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // last_name
            // 
            resources.ApplyResources(this.last_name, "last_name");
            this.last_name.Name = "last_name";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // phone_field
            // 
            resources.ApplyResources(this.phone_field, "phone_field");
            this.phone_field.Name = "phone_field";
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // username_profile
            // 
            resources.ApplyResources(this.username_profile, "username_profile");
            this.username_profile.Name = "username_profile";
            this.username_profile.TextChanged += new System.EventHandler(this.username_profile_TextChanged);
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            // 
            // password_fld
            // 
            resources.ApplyResources(this.password_fld, "password_fld");
            this.password_fld.Name = "password_fld";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // descrip
            // 
            resources.ApplyResources(this.descrip, "descrip");
            this.descrip.Name = "descrip";
            this.descrip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Name = "label5";
            // 
            // id_fld
            // 
            resources.ApplyResources(this.id_fld, "id_fld");
            this.id_fld.ForeColor = System.Drawing.Color.Crimson;
            this.id_fld.Name = "id_fld";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Patient_profile_module
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.id_fld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_fld);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username_profile);
            this.Controls.Add(this.username);
            this.Controls.Add(this.phone_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_profile_module";
            this.Load += new System.EventHandler(this.Patient_profile_module_Load);
            this.main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button Reservation_btn;
        private System.Windows.Forms.Button My_profile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_field;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox username_profile;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox password_fld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label id_fld;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}