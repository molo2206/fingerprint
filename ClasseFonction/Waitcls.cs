using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Views.Notification;

namespace test.ClasseFonction
{
    public class Waitcls
    {
        Waitform wait;
        Thread loathread;

        public void Show()
        {
            //loadthread
        }

        public void Show(Form parent)
        {

        }

        public void Close()
        {
            if (wait != null)
            {
                wait.BeginInvoke(new System.Threading.ThreadStart(wait.Close));
                wait = null;
                loathread = null;
            }
        }
        private void LoadingProcess()
        {
            wait = new Waitform();
            wait.ShowDialog();
        }

        private void LoadingeProcess(object parent)
        {
            //Form parent1 = parent as Form;
            //wait = new Waitform(parent1);
            //wait.ShowDialog();
        }
    }
}
