using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fsociety;
namespace MrRobot
{
    class Controller
    {
        protected ArrayList mList;

        public Controller()
        {
            mList = new ArrayList();
        }

        public void AddModel(Model m)
        {
            mList.Add(m);
        }

        public int count() {
            return mList.Count;
        }

        // virtual keyword allow the method to be overriden
        public virtual void ActionPerformed(int action)
        {
            throw new NotImplementedException();
        }
        
    }
}
