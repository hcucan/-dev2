using System;
using System.Collections.Generic;
using System.Text;

namespace ödev2
{
    class Gun
    {
        public string Name { get; set; } 
        public int MaxRange { get; set; }
        public int MinRange { get; set; }
       
    }
    class ShortRange:Gun
    {
        public string Name { get; set; } = "Karambit";
        public int MaxRange { get; set; } = 10;
        public int MinRange { get; set; } = 0;

    }
    class MediumRange : Gun
    {
        public string Name { get; set; } = "M4A1-S";
        public int MaxRange { get; set; } = 70;
        public int MinRange { get; set; } = 11;

    }
    class LongRange : Gun
    {
        public string Name { get; set; } = "AWP";
        public int MaxRange { get; set; } = 100;
        public int MinRange { get; set; } = 71;

    }

}
