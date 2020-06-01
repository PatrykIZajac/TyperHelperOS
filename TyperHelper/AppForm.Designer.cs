namespace TyperHelper
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayTableData = new System.Windows.Forms.Button();
            this.DisplayTyperBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TyperPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TyperPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.DisplayTableData);
            this.panel1.Controls.Add(this.DisplayTyperBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 450);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Wyloguj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayTableData
            // 
            this.DisplayTableData.BackColor = System.Drawing.Color.Transparent;
            this.DisplayTableData.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayTableData.FlatAppearance.BorderSize = 0;
            this.DisplayTableData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayTableData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayTableData.ForeColor = System.Drawing.Color.White;
            this.DisplayTableData.Location = new System.Drawing.Point(0, 155);
            this.DisplayTableData.Name = "DisplayTableData";
            this.DisplayTableData.Size = new System.Drawing.Size(154, 66);
            this.DisplayTableData.TabIndex = 3;
            this.DisplayTableData.Text = "Tabela";
            this.DisplayTableData.UseVisualStyleBackColor = false;
            this.DisplayTableData.UseWaitCursor = true;
            this.DisplayTableData.Click += new System.EventHandler(this.DisplayTableData_Click);
            // 
            // DisplayTyperBtn
            // 
            this.DisplayTyperBtn.BackColor = System.Drawing.Color.Transparent;
            this.DisplayTyperBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayTyperBtn.FlatAppearance.BorderSize = 0;
            this.DisplayTyperBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayTyperBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayTyperBtn.ForeColor = System.Drawing.Color.White;
            this.DisplayTyperBtn.Location = new System.Drawing.Point(0, 89);
            this.DisplayTyperBtn.Name = "DisplayTyperBtn";
            this.DisplayTyperBtn.Size = new System.Drawing.Size(154, 66);
            this.DisplayTyperBtn.TabIndex = 2;
            this.DisplayTyperBtn.Text = "Typer";
            this.DisplayTyperBtn.UseVisualStyleBackColor = false;
            this.DisplayTyperBtn.UseWaitCursor = true;
            this.DisplayTyperBtn.Click += new System.EventHandler(this.DisplayTyperBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TyperPanel
            // 
            this.TyperPanel.BackColor = System.Drawing.Color.White;
            this.TyperPanel.Controls.Add(this.panel2);
            this.TyperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TyperPanel.Location = new System.Drawing.Point(154, 0);
            this.TyperPanel.Name = "TyperPanel";
            this.TyperPanel.Size = new System.Drawing.Size(646, 450);
            this.TyperPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 49);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TyperPanel);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AppForm";
            this.Text = "TyperHelper";
            this.Load += new System.EventHandler(this.AppForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TyperPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DisplayTyperBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TyperPanel;
        private System.Windows.Forms.Button DisplayTableData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}