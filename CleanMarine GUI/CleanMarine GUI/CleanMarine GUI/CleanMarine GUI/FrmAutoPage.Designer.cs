namespace CleanMarine_GUI
{
    partial class FrmAutoPage
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutoPage));
			this.DortgenBox = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxBoy = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxEn = new System.Windows.Forms.TextBox();
			this.DaireBox = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCap = new System.Windows.Forms.TextBox();
			this.gonderButon = new System.Windows.Forms.Button();
			this.DaireButon = new System.Windows.Forms.RadioButton();
			this.DortgenButton = new System.Windows.Forms.RadioButton();
			this.BatteryCharge = new System.Windows.Forms.Label();
			this.BatteryLevel = new System.Windows.Forms.Label();
			this.BatteryBar = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.path = new System.Windows.Forms.Panel();
			this.kesingonderbuton = new System.Windows.Forms.Button();
			this.logo = new System.Windows.Forms.Button();
			this.DortgenBox.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.DaireBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// DortgenBox
			// 
			this.DortgenBox.BackColor = System.Drawing.Color.Transparent;
			this.DortgenBox.Controls.Add(this.label5);
			this.DortgenBox.Controls.Add(this.textBoxBoy);
			this.DortgenBox.Controls.Add(this.groupBox4);
			this.DortgenBox.Controls.Add(this.DaireBox);
			this.DortgenBox.Location = new System.Drawing.Point(139, 171);
			this.DortgenBox.Name = "DortgenBox";
			this.DortgenBox.Size = new System.Drawing.Size(135, 123);
			this.DortgenBox.TabIndex = 45;
			this.DortgenBox.TabStop = false;
			this.DortgenBox.Text = "Alanın boyu kaç cm?";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 44);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 15);
			this.label5.TabIndex = 50;
			this.label5.Text = "Min : 60  -  Max :2000";
			// 
			// textBoxBoy
			// 
			this.textBoxBoy.Location = new System.Drawing.Point(12, 22);
			this.textBoxBoy.Name = "textBoxBoy";
			this.textBoxBoy.Size = new System.Drawing.Size(100, 20);
			this.textBoxBoy.TabIndex = 27;
			this.textBoxBoy.TextChanged += new System.EventHandler(this.textBoxBoy_TextChanged);
			this.textBoxBoy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBoy_KeyPress);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.textBoxEn);
			this.groupBox4.Location = new System.Drawing.Point(0, 59);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(135, 63);
			this.groupBox4.TabIndex = 46;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Alanın eni kaç cm ?";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 42);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 15);
			this.label4.TabIndex = 49;
			this.label4.Text = "Min : 40  -  Max :2000";
			// 
			// textBoxEn
			// 
			this.textBoxEn.Location = new System.Drawing.Point(12, 19);
			this.textBoxEn.Name = "textBoxEn";
			this.textBoxEn.Size = new System.Drawing.Size(100, 20);
			this.textBoxEn.TabIndex = 26;
			this.textBoxEn.TextChanged += new System.EventHandler(this.textBoxEn_TextChanged);
			this.textBoxEn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEn_KeyPress);
			// 
			// DaireBox
			// 
			this.DaireBox.BackColor = System.Drawing.Color.Transparent;
			this.DaireBox.Controls.Add(this.label3);
			this.DaireBox.Controls.Add(this.textBoxCap);
			this.DaireBox.Location = new System.Drawing.Point(0, 0);
			this.DaireBox.Name = "DaireBox";
			this.DaireBox.Size = new System.Drawing.Size(152, 60);
			this.DaireBox.TabIndex = 44;
			this.DaireBox.TabStop = false;
			this.DaireBox.Text = "Dairenin çapı kaç cm?";
			this.DaireBox.Visible = false;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 42);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 15);
			this.label3.TabIndex = 48;
			this.label3.Text = "Min : 10  -  Max : 1000";
			// 
			// textBoxCap
			// 
			this.textBoxCap.Location = new System.Drawing.Point(25, 22);
			this.textBoxCap.Name = "textBoxCap";
			this.textBoxCap.Size = new System.Drawing.Size(100, 20);
			this.textBoxCap.TabIndex = 24;
			this.textBoxCap.TextChanged += new System.EventHandler(this.textBoxCap_TextChanged);
			this.textBoxCap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCap_KeyPress);
			// 
			// gonderButon
			// 
			this.gonderButon.BackColor = System.Drawing.Color.Transparent;
			this.gonderButon.ForeColor = System.Drawing.Color.Black;
			this.gonderButon.Location = new System.Drawing.Point(169, 353);
			this.gonderButon.Name = "gonderButon";
			this.gonderButon.Size = new System.Drawing.Size(100, 24);
			this.gonderButon.TabIndex = 43;
			this.gonderButon.Text = "yolu çiz";
			this.gonderButon.UseVisualStyleBackColor = false;
			this.gonderButon.Click += new System.EventHandler(this.gonderButon_Click);
			// 
			// DaireButon
			// 
			this.DaireButon.AutoSize = true;
			this.DaireButon.BackColor = System.Drawing.Color.Transparent;
			this.DaireButon.Location = new System.Drawing.Point(148, 148);
			this.DaireButon.Name = "DaireButon";
			this.DaireButon.Size = new System.Drawing.Size(87, 17);
			this.DaireButon.TabIndex = 42;
			this.DaireButon.Text = "Dairesel Alan";
			this.DaireButon.UseVisualStyleBackColor = false;
			// 
			// DortgenButton
			// 
			this.DortgenButton.AutoSize = true;
			this.DortgenButton.BackColor = System.Drawing.Color.Transparent;
			this.DortgenButton.Checked = true;
			this.DortgenButton.Location = new System.Drawing.Point(148, 132);
			this.DortgenButton.Name = "DortgenButton";
			this.DortgenButton.Size = new System.Drawing.Size(87, 17);
			this.DortgenButton.TabIndex = 41;
			this.DortgenButton.TabStop = true;
			this.DortgenButton.Text = "Dörtgen Alan";
			this.DortgenButton.UseVisualStyleBackColor = false;
			this.DortgenButton.CheckedChanged += new System.EventHandler(this.DortgenButton_CheckedChanged);
			// 
			// BatteryCharge
			// 
			this.BatteryCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BatteryCharge.AutoSize = true;
			this.BatteryCharge.Location = new System.Drawing.Point(760, 17);
			this.BatteryCharge.Name = "BatteryCharge";
			this.BatteryCharge.Size = new System.Drawing.Size(15, 13);
			this.BatteryCharge.TabIndex = 38;
			this.BatteryCharge.Text = "%";
			// 
			// BatteryLevel
			// 
			this.BatteryLevel.AutoSize = true;
			this.BatteryLevel.Location = new System.Drawing.Point(759, 22);
			this.BatteryLevel.Name = "BatteryLevel";
			this.BatteryLevel.Size = new System.Drawing.Size(0, 13);
			this.BatteryLevel.TabIndex = 37;
			// 
			// BatteryBar
			// 
			this.BatteryBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BatteryBar.BackColor = System.Drawing.SystemColors.Control;
			this.BatteryBar.Location = new System.Drawing.Point(732, 17);
			this.BatteryBar.MarqueeAnimationSpeed = 30;
			this.BatteryBar.Name = "BatteryBar";
			this.BatteryBar.Size = new System.Drawing.Size(26, 13);
			this.BatteryBar.TabIndex = 36;
			this.BatteryBar.Value = 90;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(313, 51);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 20);
			this.label2.TabIndex = 35;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(273, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 26);
			this.label1.TabIndex = 34;
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM5";
			// 
			// path
			// 
			this.path.BackColor = System.Drawing.Color.Transparent;
			this.path.Location = new System.Drawing.Point(456, 128);
			this.path.Name = "path";
			this.path.Size = new System.Drawing.Size(200, 200);
			this.path.TabIndex = 46;
			this.path.Paint += new System.Windows.Forms.PaintEventHandler(this.path_Paint);
			// 
			// kesingonderbuton
			// 
			this.kesingonderbuton.BackColor = System.Drawing.Color.Transparent;
			this.kesingonderbuton.Location = new System.Drawing.Point(301, 354);
			this.kesingonderbuton.Name = "kesingonderbuton";
			this.kesingonderbuton.Size = new System.Drawing.Size(127, 23);
			this.kesingonderbuton.TabIndex = 47;
			this.kesingonderbuton.Text = "koordiantlari gonder";
			this.kesingonderbuton.UseVisualStyleBackColor = false;
			this.kesingonderbuton.Click += new System.EventHandler(this.kesingonderbuton_Click);
			// 
			// logo
			// 
			this.logo.BackColor = System.Drawing.Color.Transparent;
			this.logo.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.logo;
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.logo.FlatAppearance.BorderSize = 0;
			this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logo.ForeColor = System.Drawing.Color.Transparent;
			this.logo.Location = new System.Drawing.Point(-10, -11);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(136, 121);
			this.logo.TabIndex = 39;
			this.logo.UseVisualStyleBackColor = true;
			// 
			// FrmAutoPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.kdlx;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(787, 430);
			this.Controls.Add(this.kesingonderbuton);
			this.Controls.Add(this.path);
			this.Controls.Add(this.DortgenBox);
			this.Controls.Add(this.gonderButon);
			this.Controls.Add(this.DaireButon);
			this.Controls.Add(this.DortgenButton);
			this.Controls.Add(this.logo);
			this.Controls.Add(this.BatteryCharge);
			this.Controls.Add(this.BatteryLevel);
			this.Controls.Add(this.BatteryBar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAutoPage";
			this.Text = "FrmAutoPage";
			this.TransparencyKey = System.Drawing.Color.Azure;
			this.DortgenBox.ResumeLayout(false);
			this.DortgenBox.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.DaireBox.ResumeLayout(false);
			this.DaireBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox DortgenBox;
        private System.Windows.Forms.TextBox textBoxBoy;
        private System.Windows.Forms.GroupBox DaireBox;
        private System.Windows.Forms.TextBox textBoxCap;
        private System.Windows.Forms.TextBox textBoxEn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button gonderButon;
        private System.Windows.Forms.RadioButton DaireButon;
        private System.Windows.Forms.RadioButton DortgenButton;
        private System.Windows.Forms.Button logo;
        private System.Windows.Forms.Label BatteryCharge;
        private System.Windows.Forms.Label BatteryLevel;
        private System.Windows.Forms.ProgressBar BatteryBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel path;
        private System.Windows.Forms.Button kesingonderbuton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}