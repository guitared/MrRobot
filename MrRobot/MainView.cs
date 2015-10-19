using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fsociety;
namespace MrRobot
{
    class MainView : View
    {
        public void Notify(Model m) {
            PrintMessage(((MyModel) m).GetMessage());
        }

        private void PrintMessage(string message) {
            Console.WriteLine("Message:" + message);
        }

        //public override void PerformSendHello(){
        // message = "hello";
        // NotifyAll();
        //}
    }
}
