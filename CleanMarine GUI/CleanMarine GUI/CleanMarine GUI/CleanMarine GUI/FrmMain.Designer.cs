namespace CleanMarine_GUI
{
    partial class Cleanmarine
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cleanmarine));
			this.logo = new System.Windows.Forms.Button();
			this.mainPage = new System.Windows.Forms.Panel();
			this.otonombuton = new System.Windows.Forms.Button();
			this.Manuelbuton = new System.Windows.Forms.Button();
			this.RehberButon = new System.Windows.Forms.Button();
			this.mainPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// logo
			// 
			this.logo.BackColor = System.Drawing.SystemColors.Menu;
			this.logo.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.CLEAN_MARINE;
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.logo.FlatAppearance.BorderSize = 0;
			this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logo.ForeColor = System.Drawing.Color.Transparent;
			this.logo.Location = new System.Drawing.Point(-881, -10);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(3116, 754);
			this.logo.TabIndex = 40;
			this.logo.UseVisualStyleBackColor = false;
			// 
			// mainPage
			// 
			this.mainPage.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.CLEAN_MARINE;
			this.mainPage.Controls.Add(this.otonombuton);
			this.mainPage.Controls.Add(this.Manuelbuton);
			this.mainPage.Controls.Add(this.RehberButon);
			this.mainPage.Controls.Add(this.logo);
			this.mainPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPage.Location = new System.Drawing.Point(0, 0);
			this.mainPage.Name = "mainPage";
			this.mainPage.Size = new System.Drawing.Size(1370, 749);
			this.mainPage.TabIndex = 6;
			this.mainPage.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPage_Paint);
			// 
			// otonombuton
			// 
			this.otonombuton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.autologo2;
			this.otonombuton.Location = new System.Drawing.Point(558, 499);
			this.otonombuton.Name = "otonombuton";
			this.otonombuton.Size = new System.Drawing.Size(78, 78);
			this.otonombuton.TabIndex = 43;
			this.otonombuton.UseVisualStyleBackColor = true;
			this.otonombuton.Click += new System.EventHandler(this.otonombuton_Click);
			this.otonombuton.MouseEnter += new System.EventHandler(this.RehberButon_MouseEnter);
			this.otonombuton.MouseLeave += new System.EventHandler(this.RehberButon_MouseLeave);
			// 
			// Manuelbuton
			// 
			this.Manuelbuton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.manual;
			this.Manuelbuton.Location = new System.Drawing.Point(463, 499);
			this.Manuelbuton.Name = "Manuelbuton";
			this.Manuelbuton.Size = new System.Drawing.Size(79, 78);
			this.Manuelbuton.TabIndex = 42;
			this.Manuelbuton.UseVisualStyleBackColor = true;
			this.Manuelbuton.Click += new System.EventHandler(this.Manuelbuton_Click);
			this.Manuelbuton.MouseEnter += new System.EventHandler(this.RehberButon_MouseEnter);
			this.Manuelbuton.MouseLeave += new System.EventHandler(this.RehberButon_MouseLeave);
			// 
			// RehberButon
			// 
			this.RehberButon.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.rehberrr;
			this.RehberButon.Location = new System.Drawing.Point(370, 499);
			this.RehberButon.Name = "RehberButon";
			this.RehberButon.Size = new System.Drawing.Size(78, 78);
			this.RehberButon.TabIndex = 41;
			this.RehberButon.UseVisualStyleBackColor = true;
			this.RehberButon.Click += new System.EventHandler(this.RehberButon_Click);
			this.RehberButon.MouseEnter += new System.EventHandler(this.RehberButon_MouseEnter);
			this.RehberButon.MouseLeave += new System.EventHandler(this.RehberButon_MouseLeave);
			// 
			// Cleanmarine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.sonn;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.mainPage);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Cleanmarine";
			this.Text = "FrmMain";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.mainPage.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
		private System.Windows.Forms.Button logo;
		private System.Windows.Forms.Panel mainPage;
		private System.Windows.Forms.Button RehberButon;
		private System.Windows.Forms.Button Manuelbuton;
		private System.Windows.Forms.Button otonombuton;
	}
}