
using System;
using System.Runtime.CompilerServices;

namespace ClassLibrary1
{
    public class Class1
    {
        //public delegate void MyDelegate(int x, int y);

        public event Predicate<int> myEvent;
            
        public bool RaiseEvent(int x)
        {
            if(this.myEvent != null)
            {
                bool m= this.myEvent(x);
                return m;
            }
            else
            {
                return false;
            }
           
        }
    }
}
