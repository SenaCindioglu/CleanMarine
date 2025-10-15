
namespace RobotGridTraversal
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private Button buttonStart;
        private Panel panelGrid;

        private void InitializeComponent()
        {
            this.textBoxWidth = new TextBox();
            this.textBoxHeight = new TextBox();
            this.buttonStart = new Button();
            this.panelGrid = new Panel();
            this.SuspendLayout();

            // textBoxWidth
            this.textBoxWidth.Location = new System.Drawing.Point(12, 12);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 0;
            this.textBoxWidth.PlaceholderText = "Width";

            // textBoxHeight
            this.textBoxHeight.Location = new System.Drawing.Point(12, 38);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 1;
            this.textBoxHeight.PlaceholderText = "Height";

            // buttonStart
            this.buttonStart.Location = new System.Drawing.Point(12, 64);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);

            // panelGrid
            this.panelGrid.Location = new System.Drawing.Point(130, 12);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(400, 400);
            this.panelGrid.TabIndex = 3;

            // Form1
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.panelGrid);
            this.Name = "Form1";
            this.Text = "Robot Grid Traversal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

