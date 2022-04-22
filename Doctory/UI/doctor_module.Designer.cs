namespace Doctory.UI
{
    partial class doctor_module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor_module));
            this.main_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Appointment_btn = new System.Windows.Forms.Button();
            this.My_profile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorName = new System.Windows.Forms.Label();
            this.Reservation_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.ForestGreen;
            this.main_panel.Controls.Add(this.pictureBox2);
            this.main_panel.Controls.Add(this.label2);
            this.main_panel.Controls.Add(this.close);
            this.main_panel.Location = new System.Drawing.Point(-1, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(4);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1373, 52);
            this.main_panel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(524, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Welcome To Doctor Pannel";
            // 
            // Appointment_btn
            // 
            this.Appointment_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Appointment_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Appointment_btn.FlatAppearance.BorderSize = 0;
            this.Appointment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Appointment_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Appointment_btn.Location = new System.Drawing.Point(582, 606);
            this.Appointment_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Appointment_btn.Name = "Appointment_btn";
            this.Appointment_btn.Size = new System.Drawing.Size(203, 44);
            this.Appointment_btn.TabIndex = 1;
            this.Appointment_btn.Text = "My schedule";
            this.Appointment_btn.UseVisualStyleBackColor = false;
            this.Appointment_btn.Click += new System.EventHandler(this.Appointment_btn_Click);
            // 
            // My_profile
            // 
            this.My_profile.BackColor = System.Drawing.Color.ForestGreen;
            this.My_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.My_profile.FlatAppearance.BorderSize = 0;
            this.My_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.My_profile.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.My_profile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.My_profile.Location = new System.Drawing.Point(367, 516);
            this.My_profile.Margin = new System.Windows.Forms.Padding(4);
            this.My_profile.Name = "My_profile";
            this.My_profile.Size = new System.Drawing.Size(175, 44);
            this.My_profile.TabIndex = 0;
            this.My_profile.Text = "My Profile";
            this.My_profile.UseVisualStyleBackColor = false;
            this.My_profile.Click += new System.EventHandler(this.My_profile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(473, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome Doctor:";
            // 
            // doctorName
            // 
            this.doctorName.AutoSize = true;
            this.doctorName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.doctorName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorName.ForeColor = System.Drawing.Color.ForestGreen;
            this.doctorName.Location = new System.Drawing.Point(657, 463);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(190, 28);
            this.doctorName.TabIndex = 5;
            this.doctorName.Text = "Doctor Name Here";
            this.doctorName.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reservation_btn
            // 
            this.Reservation_btn.BackColor = System.Drawing.Color.ForestGreen;
            this.Reservation_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Reservation_btn.FlatAppearance.BorderSize = 0;
            this.Reservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reservation_btn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.Reservation_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Reservation_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Reservation_btn.Location = new System.Drawing.Point(820, 516);
            this.Reservation_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Reservation_btn.Name = "Reservation_btn";
            this.Reservation_btn.Size = new System.Drawing.Size(203, 44);
            this.Reservation_btn.TabIndex = 6;
            this.Reservation_btn.Text = "Appointments";
            this.Reservation_btn.UseVisualStyleBackColor = false;
            this.Reservation_btn.Click += new System.EventHandler(this.Reservation_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::Doctory.Properties.Resources.log_out;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.close.Location = new System.Drawing.Point(1327, 0);
            this.close.Margin = new System.Windows.Forms.Padding(4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(46, 52);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 21;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // doctor_module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 783);
            this.Controls.Add(this.Reservation_btn);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.Appointment_btn);
            this.Controls.Add(this.My_profile);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "doctor_module";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "doctor_module";
            this.Load += new System.EventHandler(this.doctor_module_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Button Appointment_btn;
        private System.Windows.Forms.Button My_profile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label doctorName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Reservation_btn;
    }
}