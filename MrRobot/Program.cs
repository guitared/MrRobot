using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using fsociety;
namespace MrRobot
{
    class Program
    {

        static void Main(string[] args)
        {

            View view = (View) new MainView();
            Model model = new MyModel();
            Controller controller = new MainController();
            try
            {
                model = (MyModel)Activator.CreateInstance(Type.GetType("MrRobot.CLASS"));
                model.AttachObserver(view);
            }
            catch (Exception e)
            {
                model = new MyModel();
                model.AttachObserver(view);
            }
            finally
            {
                controller.AddModel((MyModel)model);
            }
            controller.ActionPerformed(MainController.WELCOME);
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                controller.ActionPerformed(MainController.KEYPRESS);
            }
            controller.ActionPerformed(MainController.GOODBYE);
            Console.ReadKey();

        }

    }
}
