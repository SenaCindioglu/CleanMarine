namespace CleanMarine_GUI
{
    partial class FrmManualPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManualPage));
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.SpeedBar = new System.Windows.Forms.TrackBar();
			this.BatteryBar = new System.Windows.Forms.ProgressBar();
			this.BatteryLevel = new System.Windows.Forms.Label();
			this.BatteryCharge = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.LeftButton = new System.Windows.Forms.Button();
			this.ForwardButton = new System.Windows.Forms.Button();
			this.RightButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.AgDoluluk = new System.Windows.Forms.Label();
			this.guiControlButton = new System.Windows.Forms.RadioButton();
			this.RCControlButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.PortName = "COM7";
			// 
			// SpeedBar
			// 
			this.SpeedBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.SpeedBar.Location = new System.Drawing.Point(468, 195);
			this.SpeedBar.Maximum = 4;
			this.SpeedBar.Minimum = 1;
			this.SpeedBar.Name = "SpeedBar";
			this.SpeedBar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.SpeedBar.Size = new System.Drawing.Size(45, 105);
			this.SpeedBar.TabIndex = 4;
			this.SpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.SpeedBar.Value = 4;
			this.SpeedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
			// 
			// BatteryBar
			// 
			this.BatteryBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BatteryBar.BackColor = System.Drawing.SystemColors.Control;
			this.BatteryBar.Location = new System.Drawing.Point(500, 159);
			this.BatteryBar.MarqueeAnimationSpeed = 30;
			this.BatteryBar.Name = "BatteryBar";
			this.BatteryBar.Size = new System.Drawing.Size(26, 13);
			this.BatteryBar.TabIndex = 6;
			this.BatteryBar.Value = 90;
			// 
			// BatteryLevel
			// 
			this.BatteryLevel.AutoSize = true;
			this.BatteryLevel.Location = new System.Drawing.Point(738, 19);
			this.BatteryLevel.Name = "BatteryLevel";
			this.BatteryLevel.Size = new System.Drawing.Size(0, 13);
			this.BatteryLevel.TabIndex = 9;
			// 
			// BatteryCharge
			// 
			this.BatteryCharge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BatteryCharge.AutoSize = true;
			this.BatteryCharge.BackColor = System.Drawing.Color.Transparent;
			this.BatteryCharge.Location = new System.Drawing.Point(532, 159);
			this.BatteryCharge.Name = "BatteryCharge";
			this.BatteryCharge.Size = new System.Drawing.Size(15, 13);
			this.BatteryCharge.TabIndex = 10;
			this.BatteryCharge.Text = "%";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(507, 181);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 26);
			this.label1.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(337, 147);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 20);
			this.label2.TabIndex = 12;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// LeftButton
			// 
			this.LeftButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.LeftButton.BackColor = System.Drawing.Color.Transparent;
			this.LeftButton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.arrow_head_L;
			this.LeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.LeftButton.FlatAppearance.BorderSize = 0;
			this.LeftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftButton.ForeColor = System.Drawing.Color.Transparent;
			this.LeftButton.Location = new System.Drawing.Point(341, 259);
			this.LeftButton.Name = "LeftButton";
			this.LeftButton.Size = new System.Drawing.Size(35, 41);
			this.LeftButton.TabIndex = 2;
			this.LeftButton.UseVisualStyleBackColor = false;
			this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
			// 
			// ForwardButton
			// 
			this.ForwardButton.AccessibleName = "";
			this.ForwardButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
			this.ForwardButton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.arrow_head_U;
			this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ForwardButton.FlatAppearance.BorderSize = 0;
			this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ForwardButton.Location = new System.Drawing.Point(382, 225);
			this.ForwardButton.Name = "ForwardButton";
			this.ForwardButton.Size = new System.Drawing.Size(39, 31);
			this.ForwardButton.TabIndex = 1;
			this.ForwardButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.ForwardButton.UseVisualStyleBackColor = false;
			this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
			// 
			// RightButton
			// 
			this.RightButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.RightButton.BackColor = System.Drawing.Color.Transparent;
			this.RightButton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.arrow_head;
			this.RightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RightButton.FlatAppearance.BorderSize = 0;
			this.RightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightButton.ForeColor = System.Drawing.Color.Transparent;
			this.RightButton.Location = new System.Drawing.Point(415, 259);
			this.RightButton.Name = "RightButton";
			this.RightButton.Size = new System.Drawing.Size(47, 37);
			this.RightButton.TabIndex = 0;
			this.RightButton.UseMnemonic = false;
			this.RightButton.UseVisualStyleBackColor = false;
			this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(441, 315);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "HIZ AYARI";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(338, 299);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 16);
			this.label4.TabIndex = 18;
			this.label4.Text = "YÖN KONTROL";
			// 
			// AgDoluluk
			// 
			this.AgDoluluk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.AgDoluluk.AutoSize = true;
			this.AgDoluluk.BackColor = System.Drawing.Color.Transparent;
			this.AgDoluluk.Location = new System.Drawing.Point(660, 265);
			this.AgDoluluk.Name = "AgDoluluk";
			this.AgDoluluk.Size = new System.Drawing.Size(15, 13);
			this.AgDoluluk.TabIndex = 20;
			this.AgDoluluk.Text = "%";
			// 
			// guiControlButton
			// 
			this.guiControlButton.AutoSize = true;
			this.guiControlButton.BackColor = System.Drawing.Color.Transparent;
			this.guiControlButton.Checked = true;
			this.guiControlButton.Location = new System.Drawing.Point(533, 271);
			this.guiControlButton.Name = "guiControlButton";
			this.guiControlButton.Size = new System.Drawing.Size(14, 13);
			this.guiControlButton.TabIndex = 50;
			this.guiControlButton.TabStop = true;
			this.guiControlButton.UseVisualStyleBackColor = false;
			this.guiControlButton.CheckedChanged += new System.EventHandler(this.guiControlButton_CheckedChanged);
			// 
			// RCControlButton
			// 
			this.RCControlButton.AutoSize = true;
			this.RCControlButton.BackColor = System.Drawing.Color.Transparent;
			this.RCControlButton.Location = new System.Drawing.Point(533, 250);
			this.RCControlButton.Name = "RCControlButton";
			this.RCControlButton.Size = new System.Drawing.Size(14, 13);
			this.RCControlButton.TabIndex = 51;
			this.RCControlButton.TabStop = true;
			this.RCControlButton.UseVisualStyleBackColor = false;
			// 
			// FrmManualPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.manualcontrol1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(834, 424);
			this.Controls.Add(this.RCControlButton);
			this.Controls.Add(this.guiControlButton);
			this.Controls.Add(this.AgDoluluk);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BatteryCharge);
			this.Controls.Add(this.BatteryLevel);
			this.Controls.Add(this.BatteryBar);
			this.Controls.Add(this.SpeedBar);
			this.Controls.Add(this.LeftButton);
			this.Controls.Add(this.RightButton);
			this.Controls.Add(this.ForwardButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmManualPage";
			this.Text = "ManualPage";
			((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button LeftButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.ProgressBar BatteryBar;
        private System.Windows.Forms.Label BatteryLevel;
        private System.Windows.Forms.Label BatteryCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AgDoluluk;
        private System.Windows.Forms.RadioButton guiControlButton;
        private System.Windows.Forms.RadioButton RCControlButton;
	}
}