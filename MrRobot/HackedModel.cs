﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class HackedModel : MyModel 
    {
        public override void PerformSendMessage()
        {
            message = "570610590";
            NotifyAll();
            
        }
    }
}
