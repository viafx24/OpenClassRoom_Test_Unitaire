using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClassRoom_Test_Unitaire
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Math
    {
        public static int Factorielle(int a)
        {
            if (a <= 1)
                return 1;
            return a * Factorielle(a - 1);
        }
    }
}
