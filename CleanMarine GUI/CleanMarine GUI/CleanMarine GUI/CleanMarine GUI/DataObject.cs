using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMarine_GUI
{
    public class DataObject
    {
        
        public bool CommunicationMethod { get; set; }
        public Direction Direction { get; set; }
        public Speed Speed { get; set; }
        public Shape Shape { get; set; }
    }

 
    public enum Direction { Stop, Left, Right, Forward }
    public enum Speed { Speed25, Speed50, Speed75, Speed100 }
    public enum Shape { circle, square}


}
