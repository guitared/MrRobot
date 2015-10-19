using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrRobot
{
    class MainController : Controller
    {
        public const int WELCOME = 0;
        public const int KEYPRESS = 1;
        public const int GOODBYE = 2;

        public override void ActionPerformed(int action)
        {
            foreach (MyModel m in mList)
            {
                switch (action)
                {
                    case WELCOME:
                        m.PerformWelcome();
                        break;
                    case KEYPRESS:
                        m.PerformSendMessage();
                        break;
                    case GOODBYE:
                        m.PerformGoodbye();
                        break;
                }
            }
        }
    }
}
