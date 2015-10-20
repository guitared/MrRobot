using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fsociety;
namespace MrRobot
{
    class MyModel : Model
    {

        public string GetMessage()
        {
            return message;
        }

        public virtual void PerformSendMessage() {
            message = "570610588";
            NotifyAll();
        }
        
    }
}
