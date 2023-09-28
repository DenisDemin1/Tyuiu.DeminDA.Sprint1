using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DeminDA.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string value)
        {
            string s = value;

            if (s.Contains("hello"))
            {
                return true;
            }
            else if (s.Contains("Hello"))
            {
                return true;
            }
            else if (s.Contains("HELLO"))
            {
                return true;
            }
            else return false;
        }
    }

}




