
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RobotGridTraversal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxWidth.Text, out int width) && int.TryParse(textBoxHeight.Text, out int height))
            {
                DrawPath(width, height);
            }
            else
            {
                MessageBox.Show("Please enter valid integers for width and height.");
            }
        }

        private void DrawPath(int width, int height)
        {
            panelGrid.Controls.Clear();
            panelGrid.Width = width * 30; // Adjust the size based on the grid dimensions
            panelGrid.Height = height * 30;

            for (int j = 0; j < width; j++)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < height; i++)
                    {
                        DrawCell(i, j);
                    }
                }
                else
                {
                    for (int i = height - 1; i >= 0; i--)
                    {
                        DrawCell(i, j);
                    }
                }
            }
        }

        private void DrawCell(int i, int j)
        {
            Label cell = new Label
            {
                BorderStyle = BorderStyle.FixedSingle,
                Width = 30,
                Height = 30,
                Location = new Point(j * 30, i * 30),
                Text = $"{i},{j}",
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.LightGray
            };
            panelGrid.Controls.Add(cell);
        }
    }
}
