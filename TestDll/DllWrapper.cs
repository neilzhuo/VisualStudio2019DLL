using MathLibraryCSharpDotNet5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestDll
{
    class DllWrapper : IDllWrapper
    {
        [DllImport(@"..\..\..\..\MathLibraryCPlusPlus\x64\Debug\MathLibraryCPlusPlus.dll")]
        public static extern double add(double a, double b);

        [DllImport(@"..\..\..\..\MathLibraryCPlusPlus\x64\Debug\MathLibraryCPlusPlus.dll")]
        public static extern double substract(double a, double b);

        [DllImport(@"..\..\..\..\MathLibraryCPlusPlus\x64\Debug\MathLibraryCPlusPlus.dll")]
        public static extern double multiply(double a, double b);

        [DllImport(@"..\..\..\..\MathLibraryCPlusPlus\x64\Debug\MathLibraryCPlusPlus.dll")]
        public static extern double divide(double a, double b);

        private MathsCSharpDotNet5 mathsCSharpDotNet5;

        public DllWrapper()
        {
            mathsCSharpDotNet5 = new MathsCSharpDotNet5();
        }

        public double AddFromDll(double a, double b)
        {
            return add(a, b);
        }

        public double SubstractFromDll(double a, double b)
        {
            return substract(a, b);
        }

        public double MultiplyFromDll(double a, double b)
        {
            return multiply(a, b);
        }

        public double DivideFromDll(double a, double b)
        {
            return divide(a, b);
        }

        public double SqrtFromDll(double a)
        {
            return mathsCSharpDotNet5.Sqrt(a);
        }
    }
}
