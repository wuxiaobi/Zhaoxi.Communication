﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.Communication
{
    public class SerialInfo
    {
        public string PortName { set; get; } ="COM1";
        public int BaudRate { get; set; } = 9600;
        public int DataBit { get; set; } = 8;
        public Parity Parity { get; set; } = Parity.None;
        public StopBits StopBits { get; set; } = StopBits.One;
    }
}
