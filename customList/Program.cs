using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> custom = new CustomList<int>();
            CustomList<int> anotherOne = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int aNum = 1;
            int aNum2 = 5;
            custom.Add(aNum);
            custom.Add(aNum);
            custom.Add(aNum);
            custom.Add(aNum);
            custom.Add(aNum2);
            anotherOne.Add(aNum);
            result = custom - anotherOne;


        }
    }
}
