using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Phones
    {
        public class BasePhones
        {
            public string Number { get; set; }
            public List<string> AvailableSymbols = new List<string>
        {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            };
        }
        public class BlackWhitePhone : ButtonPhone
        {
            public string Resolution { get; set; }
            public string Color { get; set; }
            public string SizeScreen { get; set; }
            public BlackWhitePhone()
            {
                AvailableSymbols.AddRange(new List<string>
            {
                "Reset"
            });
            }
        }
        public class ButtonPhone : BasePhones
        {
            public ButtonPhone()
            {
                AvailableSymbols.AddRange(new List<string>
            {
                "Enter",
                "Cancel",
                "*",
                "#"
            });
            }
        }
        public class SmartPhone : СolorScreenPhone
        {
            public bool TouchScreen { get; set; }
            public int CountOfTouchs { get; set; }
            public int CountOfCameras { get; set; }
        }
        public class СolorScreenPhone : BlackWhitePhone
        {
            public int CountOfColors { get; set; }
            public bool DualSim { get; set; }
            public string SecondNumber { get; set; }
        }
    }
}
