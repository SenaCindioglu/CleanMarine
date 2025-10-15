namespace CleanMarine_GUI
{
    partial class CtrlManualMode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlManualMode));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BatteryCharge = new System.Windows.Forms.Label();
            this.BatteryBar = new System.Windows.Forms.ProgressBar();
            this.SpeedBar = new System.Windows.Forms.TrackBar();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            // 
            // BatteryCharge
            // 
            resources.ApplyResources(this.BatteryCharge, "BatteryCharge");
            this.BatteryCharge.Name = "BatteryCharge";
            this.BatteryCharge.UseWaitCursor = true;
            // 
            // BatteryBar
            // 
            resources.ApplyResources(this.BatteryBar, "BatteryBar");
            this.BatteryBar.BackColor = System.Drawing.SystemColors.Control;
            this.BatteryBar.MarqueeAnimationSpeed = 30;
            this.BatteryBar.Name = "BatteryBar";
            this.BatteryBar.UseWaitCursor = true;
            this.BatteryBar.Value = 90;
            // 
            // SpeedBar
            // 
            resources.ApplyResources(this.SpeedBar, "SpeedBar");
            this.SpeedBar.Name = "SpeedBar";
            this.SpeedBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SpeedBar.UseWaitCursor = true;
            // 
            // LeftButton
            // 
            resources.ApplyResources(this.LeftButton, "LeftButton");
            this.LeftButton.BackColor = System.Drawing.Color.Transparent;
            this.LeftButton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.arrow_head_L;
            this.LeftButton.FlatAppearance.BorderSize = 0;
            this.LeftButton.ForeColor = System.Drawing.Color.Transparent;
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.UseVisualStyleBackColor = false;
            this.LeftButton.UseWaitCursor = true;
            // 
            // RightButton
            // 
            resources.ApplyResources(this.RightButton, "RightButton");
            this.RightButton.BackColor = System.Drawing.Color.Transparent;
            this.RightButton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.arrow_head_U;
            this.RightButton.FlatAppearance.BorderSize = 0;
            this.RightButton.Name = "RightButton";
            this.RightButton.UseVisualStyleBackColor = false;
            this.RightButton.UseWaitCursor = true;
            // 
            // ForwardButton
            // 
            resources.ApplyResources(this.ForwardButton, "ForwardButton");
            this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.BackgroundImage = global::CleanMarine_GUI.Properties.Resources.arrow_head;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.ForeColor = System.Drawing.Color.Transparent;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.UseMnemonic = false;
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.UseWaitCursor = true;
            // 
            // CtrlManualMode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BatteryCharge);
            this.Controls.Add(this.BatteryBar);
            this.Controls.Add(this.SpeedBar);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.ForwardButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CtrlManualMode";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.SpeedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BatteryCharge;
        private System.Windows.Forms.ProgressBar BatteryBar;
        private System.Windows.Forms.TrackBar SpeedBar;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button ForwardButton;
    }
}
