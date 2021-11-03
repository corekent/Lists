using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests
{
    class TestData
    {
        public static ArrayList ForTests(int idx)
        {
            int[] array = new int[] { 1, 2, 3, 4 };
            return idx switch
            {
                0 => new ArrayList(),
                1 => new ArrayList(1),
                2 => new ArrayList(array),
                _ => new ArrayList(42)
            };
        }
    }
}
