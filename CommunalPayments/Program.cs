using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunalPayments
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculation calculation = new Calculation();
            calculation.Calculate(60, 3, 3, 60, true, 30);
        



        }
    }
}
