using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using System.Drawing.Drawing2D;
using System.Xml.Linq;
using System.Collections;

namespace CleanMarine_GUI
{
    public partial class FrmAutoPage : Form
    {
        int dortgenBoy, dortgenEn, daireCap;
        string dortgenBoytext;
        string dortgenEntext ;
        string daireCaptext;
        private Point[] pathPoints;
        private List<Point> CirclePoints = new List<Point>();
        private int[] Adata = new int[5] { 1, 1, 1, 1, 1 }; // Default initialization

        public FrmAutoPage()
        {
            InitializeComponent();
            //serialPort1.Open();
        }

        private void DortgenButton_CheckedChanged(object sender, EventArgs e)
        {
            //select the shape 
            if (DortgenButton.Checked)
            {
                DortgenBox.Visible = true;
                path.Visible = true;
                DaireBox.Visible = false;
            }
            else if (DaireButon.Checked)
            {
                DaireBox.Visible = true;
                DortgenBox.Visible = false;
                path.Visible = true;
            }
        }


        // draw the path that the vehicle will go through
        public void gonderButon_Click(object sender, EventArgs e)
        {
            string dortgenBoytext = textBoxBoy.Text;
            string dortgenEntext = textBoxEn.Text;
            string daireCaptext = textBoxCap.Text;
            int centerX, centerY;

            // Convert the string inputs to integer
            bool success1 = int.TryParse(dortgenBoytext, out dortgenBoy);
            bool success2 = int.TryParse(dortgenEntext, out dortgenEn);
            bool success3 = int.TryParse(daireCaptext, out daireCap);

            if (DortgenButton.Checked && path != null && success1 && success2)
            {
                // Generate the path points for the rectangle
                pathPoints = GeneratePathPoints(path.Width, path.Height, dortgenEn, dortgenBoy);
                // Trigger path's Paint event to redraw
                path.Invalidate();
                //PrintSquarePoints();
            }
            else if (DaireButon.Checked)
            {
                // Validate input and parse values
                if (success3 && daireCap > 0)
                {
                    // Set center of the circle to be the middle of the panel
                    centerX = path.Width / daireCap;
                    centerY = path.Height / daireCap;

                    // Clear the CirclePoints list
                    CirclePoints.Clear();

                    // Generate the circle points using Bresenham's algorithm
                    //GenerateCirclePoints(centerX, centerY, daireCap);

                    // Trigger path's Paint event to redraw
                    path.Invalidate();
                    //PrintCirclePoints();
                }
            }
        }

        
        private void path_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (DortgenButton.Checked && pathPoints != null && pathPoints.Length > 1)
            {
                // Draw the path as a polygon for the rectangle
                Pen pathPen = new Pen(Color.Blue, 3);
                g.DrawPolygon(pathPen, pathPoints);
            }
            else if (DaireButon.Checked)
            {

                // Draw the circle path
                Pen pathPen2 = new Pen(Color.Red, 3);
                int centerX = path.Width / 2;
                int centerY = path.Height / 2;
                int maxDiameter = Math.Min(path.Width, path.Height); // Ensure the largest circle fits

                for (int i = daireCap; i > 0; i -= 25)
                {
                    int diameter = i * 2;
                    if (diameter > maxDiameter)
                    {
                        diameter = maxDiameter; // Adjust the diameter if it exceeds the path size
                    }
                    g.DrawEllipse(pathPen2, centerX - diameter / 2, centerY - diameter / 2, diameter, diameter);
                }
            }
        }

        /*
         * private void GenerateCirclePoints(int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;

            while (y >= x)
            {
                AddCirclePoints(xc, yc, x, y);

                x++;
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                {
                    d = d + 4 * x + 6;
                }
            }

            // Process and sort the circle points
            CirclePoints = ProcessCircleCoordinates(CirclePoints);
        }
        private void AddCirclePoints(int xc, int yc, int x, int y)
        {

            // Add points to the list
            CirclePoints.Add(new Point(xc + x, yc + y));
            CirclePoints.Add(new Point(xc - x, yc + y));
            CirclePoints.Add(new Point(xc + x, yc - y));
            CirclePoints.Add(new Point(xc - x, yc - y));
            CirclePoints.Add(new Point(xc + y, yc + x));
            CirclePoints.Add(new Point(xc - y, yc + x));
            CirclePoints.Add(new Point(xc + y, yc - x));
            CirclePoints.Add(new Point(xc - y, yc - x));

        }

        private List<Point> ProcessCircleCoordinates(List<Point> coords)
        {
            // Remove duplicate points
            coords = coords.Distinct().ToList();

            // Find the min and max Y-coordinates
            int minY = coords.Min(p => p.Y);
            int maxY = coords.Max(p => p.Y);

            // Calculate the midpoint for dividing
            int midpointY = (minY + maxY) / 2;

            // Divide the points based on x-coordinates
            var leftHalf = coords.Where(p => p.X <= midpointY).ToList();
            var rightHalf = coords.Where(p => p.X > midpointY).ToList();

            // Sort the left half by x-coordinates in ascending order
            leftHalf = leftHalf.OrderBy(p => p.X).ToList();

            // Sort the right half by x-coordinates in descending order
            rightHalf = rightHalf.OrderByDescending(p => p.X).ToList();

            // Combine the sorted halves
            var sortedCoords = leftHalf.Concat(rightHalf).ToList();
            return sortedCoords;
        }


        //debug
        private void PrintCirclePoints()
        {
            if (CirclePoints != null)
            {
                Console.WriteLine("Circle Points:");
                foreach (Point point in CirclePoints)
                {
                    Console.WriteLine($"({point.X}, {point.Y})");
                }
            }
            else
            {
                Console.WriteLine("bosmus yaaaa");
            }
        }

        //debug
        private void PrintSquarePoints()
        {
            if (pathPoints != null)
            {
                Console.WriteLine("Circle Points:");
                foreach (Point point in pathPoints)
                {
                    Console.WriteLine($"({point.X}, {point.Y})");
                }
            }
            else
            {
                Console.WriteLine("bosmus yaaaa");
            }
        }

        */

        //generate square area algorithm

        private Point[] GeneratePathPoints(int panelWidth, int panelHeight, int width, int height)
        {
            var points = new List<Point>();

            // Calculate the scaling factors based on the panel size
            float xScale = (float)panelWidth / width;
            float yScale = (float)panelHeight / height;

            for (int j = 0; j < width; j += 5)
            {
                if (j % 2 == 0)
                {
                    for (int i = 0; i < height; i++)
                    {
                        points.Add(new Point((int)(j * xScale), (int)(i * yScale)));
                    }
                }
                else
                {
                    for (int i = height - 1; i >= 0; i--)
                    {
                        points.Add(new Point((int)(j * xScale), (int)(i * yScale)));
                    }
                }
            }
            return points.ToArray();
        }


        // send the coodinates to the arduino
        private void kesingonderbuton_Click(object sender, EventArgs e)
        {
            if (DortgenButton.Checked)
            {
                Cleanmarine.DataObject.Shape = Shape.square;
                SendData();
            }
            else if (DaireButon.Checked)
            {
                Cleanmarine.DataObject.Shape = Shape.circle;
                SendData();
            }
        }
        private void SendData()
        {
            Adata[0] = Cleanmarine.DataObject.Shape == Shape.square ? '1' : Cleanmarine.DataObject.Shape == Shape.circle ? '0' : 'N' ;
            Adata[1] = (Adata[0] == 1) ? dortgenBoy  : daireCap ;
            Adata[2] = (Adata[0] == 1) ? dortgenEn : -1 ;
            string dataToSend = string.Join(",", Adata);
            serialPort1.WriteLine(dataToSend);
        }

        //functions to make sure that the user will provide the suitable data

        private void textBoxBoy_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxEn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //asagidaki 3 fonksiyon textbox'larda sinirlari asan sayi girilmesini engelliyor.

        private void textBoxEn_TextChanged(object sender, EventArgs e)
        {
            _ = int.TryParse(textBoxEn.Text, out int valueEn);
            if (valueEn > Constents.MaxEn)  valueEn = Constents.MaxEn;
            else if (valueEn < Constents.MinEn) valueEn = Constents.MinEn;

            dortgenEn = valueEn;
            textBoxEn.Text = valueEn.ToString();
            
        }


        private void textBoxCap_TextChanged(object sender, EventArgs e)
        {
            _ = int.TryParse(textBoxCap.Text, out int value);
            if (value > Constents.MaxCap) value = Constents.MaxCap;
            else if (value < Constents.MinCap) value = Constents.MinCap;

            daireCap = value;
            textBoxCap.Text = value.ToString();
        }

        private void textBoxBoy_TextChanged(object sender, EventArgs e)
        {
            _ = int.TryParse(textBoxBoy.Text, out int valueBoy);
            if (valueBoy > Constents.MaxBoy) valueBoy = Constents.MaxBoy;
            else if (valueBoy < Constents.MinBoy) valueBoy = Constents.MinBoy;

            dortgenBoy = valueBoy;
            textBoxBoy.Text = valueBoy.ToString();
        }

    }
}
