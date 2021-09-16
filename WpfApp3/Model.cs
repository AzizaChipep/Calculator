using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    class Model
    {
        public string PlusMethod(int a, int b)
        {
            return (a + b).ToString();
        }

        public string MinusMethod(int a, int b)
        {
            return (a - b).ToString();
        }

        public string MultiplyMethod(int a, int b)
        {
            return (a * b).ToString();
        }

        public string DivideMethod(int a, int b)
        {
            if (b == 0)
                return "НЕТ ЭЭЭ";
            return (a / b).ToString();
        }

    }
}
