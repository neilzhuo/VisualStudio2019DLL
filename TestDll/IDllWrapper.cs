using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDll
{
    interface IDllWrapper
    {
        double AddFromDll(double a, double b);
        double SubstractFromDll(double a, double b);
        double MultiplyFromDll(double a, double b);
        double DivideFromDll(double a, double b);
        double SqrtFromDll(double a);
    }
}
