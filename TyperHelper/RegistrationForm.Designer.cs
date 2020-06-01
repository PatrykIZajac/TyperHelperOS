namespace TyperHelper
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registerUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.backToLoginFormBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showPasswordBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(117, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(50, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Register Your Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(52, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // registerUsernameTextBox
            // 
            this.registerUsernameTextBox.Location = new System.Drawing.Point(55, 182);
            this.registerUsernameTextBox.Name = "registerUsernameTextBox";
            this.registerUsernameTextBox.Size = new System.Drawing.Size(240, 20);
            this.registerUsernameTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(56, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(55, 225);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(240, 20);
            this.registerPasswordTextBox.TabIndex = 15;
            this.registerPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Coral;
            this.RegisterBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterBtn.BackgroundImage")));
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(55, 251);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(240, 40);
            this.RegisterBtn.TabIndex = 16;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // backToLoginFormBtn
            // 
            this.backToLoginFormBtn.FlatAppearance.BorderSize = 0;
            this.backToLoginFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginFormBtn.Location = new System.Drawing.Point(107, 297);
            this.backToLoginFormBtn.Name = "backToLoginFormBtn";
            this.backToLoginFormBtn.Size = new System.Drawing.Size(122, 69);
            this.backToLoginFormBtn.TabIndex = 17;
            this.backToLoginFormBtn.Text = "Masz już konto? zaloguj się!";
            this.backToLoginFormBtn.UseVisualStyleBackColor = true;
            this.backToLoginFormBtn.Click += new System.EventHandler(this.backToLoginFormBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(314, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 25);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showPasswordBtn
            // 
            this.showPasswordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPasswordBtn.BackgroundImage")));
            this.showPasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPasswordBtn.FlatAppearance.BorderSize = 0;
            this.showPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPasswordBtn.Location = new System.Drawing.Point(301, 225);
            this.showPasswordBtn.Name = "showPasswordBtn";
            this.showPasswordBtn.Size = new System.Drawing.Size(27, 23);
            this.showPasswordBtn.TabIndex = 19;
            this.showPasswordBtn.UseVisualStyleBackColor = true;
            this.showPasswordBtn.MouseEnter += new System.EventHandler(this.showPasswordBtn_MouseEnter);
            this.showPasswordBtn.MouseLeave += new System.EventHandler(this.showPasswordBtn_MouseLeave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 409);
            this.Controls.Add(this.showPasswordBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backToLoginFormBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.registerPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerUsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox registerUsernameTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Button RegisterBtn;
        public System.Windows.Forms.Button backToLoginFormBtn;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button showPasswordBtn;
    }
}