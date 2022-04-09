using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money();
            m.GetCard();
            WorkPass pass = new WorkPass { id = 14444 };
            pass.PassToWork(); 


            BussinesCard bussines = new BussinesCard { one = 1, two = 2 }; 
        }
    }
}
