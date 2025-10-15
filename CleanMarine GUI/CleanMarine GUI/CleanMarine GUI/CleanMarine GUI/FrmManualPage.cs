using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanMarine_GUI
{
    public partial class FrmManualPage : Form
    {
        private char[] Mdata = new char[5] { '1', '1', '1', '1', '1' }; // Default initialization
        public FrmManualPage()
        {
            InitializeComponent();
            //serialPort1.Open();
            Mdata = new char[5] { '1', '1', '1', '1', '1' };
        }

        // 5 BIT =
        // data[0] : RC(0) OR GUI(1).
        // data[1] + data[2] : right(01) , left(10) , front(11) , nothing(00)
        // data[3] + data[4] : speed: 25(00) , 50(01) , 75(10) ,100(11)

        private void SendData()
        {
            Mdata[0] = Cleanmarine.DataObject.CommunicationMethod ? '1' : '0';
            Mdata[1] = Cleanmarine.DataObject.Direction == Direction.Right ? '0' : Cleanmarine.DataObject.Direction == Direction.Left ? '1' : Cleanmarine.DataObject.Direction == Direction.Forward ? '1' : Cleanmarine.DataObject.Direction == Direction.Stop ? '0' : '0' ;
            Mdata[2] = Cleanmarine.DataObject.Direction == Direction.Right ? '1' : Cleanmarine.DataObject.Direction == Direction.Left ? '0' : Cleanmarine.DataObject.Direction == Direction.Forward ? '1' : Cleanmarine.DataObject.Direction == Direction.Stop ? '0' : '0';
            Mdata[3] = Cleanmarine.DataObject.Speed == Speed.Speed25 ? '0' : Cleanmarine.DataObject.Speed == Speed.Speed50 ? '0' : Cleanmarine.DataObject.Speed == Speed.Speed75 ? '1' : '1';
            Mdata[4] = Cleanmarine.DataObject.Speed == Speed.Speed25 ? '0' : Cleanmarine.DataObject.Speed == Speed.Speed50 ? '1' : Cleanmarine.DataObject.Speed == Speed.Speed75 ? '0' : '1';
            string dataToSend = new string(Mdata);
            //if (Cleanmarine.DataObject.Direction ==  Direction.Right)
            //{
            //    Mdata[1] = '0'; Mdata[2] = '1';
            //}
            //else if (Cleanmarine.DataObject.Direction == Direction.Left)
            //{
            //    Mdata[1] = '1'; Mdata[2] = '0';
            //}
            //else if (Cleanmarine.DataObject.Direction == Direction.Forward)
            //{
            //    Mdata[1] = '1'; Mdata[2] = '1';
            //}
            //else
            //{
            //    Mdata[1] = '0'; Mdata[2] = '0';
            //}
            //serialPort1.WriteLine(dataToSend);
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Cleanmarine.DataObject.Direction = Direction.Forward;
            
        }
        private void RightButton_Click(object sender, EventArgs e)
        {
            Cleanmarine.DataObject.Direction = Direction.Right;
            
        }
        private void LeftButton_Click(object sender, EventArgs e)
        {
            Cleanmarine.DataObject.Direction = Direction.Left;
            
        }
        private void SpeedBar_Scroll(object sender, EventArgs e)
        {
            switch (SpeedBar.Value)
            {
                case 1: Cleanmarine.DataObject.Speed = Speed.Speed25; break; // speed = 25 (00)
                case 2: Cleanmarine.DataObject.Speed = Speed.Speed50; break; // speed = 50 (01)
                case 3: Cleanmarine.DataObject.Speed = Speed.Speed75; break; // speed = 75 (10)
                case 4: Cleanmarine.DataObject.Speed = Speed.Speed100; break; // speed = 100 (11)
            }

            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendData(); // Send updated data


            //BatteryBar.Value = int.Parse(serialPort1.ReadLine());
            //BatteryCharge.Text = BatteryBar.Value.ToString();

            //AgDolulukOrani.Value = 70; //.Parse(serialPort1.ReadLine());
            //AgDoluluk.Text = AgDolulukOrani.Value.ToString();

        }

        private void guiControlButton_CheckedChanged(object sender, EventArgs e)
        {
            if (guiControlButton.Checked)
            {
                Cleanmarine.DataObject.CommunicationMethod = true;

            }
            else if (RCControlButton.Checked)
            {
                Cleanmarine.DataObject.CommunicationMethod = false;

            }
        }
    }
}
