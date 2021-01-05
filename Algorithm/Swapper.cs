using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithm
{
    public static class Swpper
    {
        public static void SwapValueAtIndices<T>(this T[] objects, int i, int j)
        {
            T temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
    }
}
