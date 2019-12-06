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
            custom.Add(1);
            custom.Add(1);
            custom.Add(1);
            custom.Add(1);
            custom.Add(5);
            custom.Remove(1);
            //custom.Remove(1);
            //custom.Remove(1);
            //custom.Remove(1);

        }
    }
}
