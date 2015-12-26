using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest2
{
    public class EventTest
    {
        private int _value;

        public delegate void NumManipulationHandler();

        public event NumManipulationHandler ChangeNum;

        public EventTest(int n)
        {
            SetValue(n);
        }
        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }

        public void SetValue(int n)
        {
            if (_value != n)
            {
                _value = n;
                OnNumChanged();
            }
        }
    }
}
