using System;
using System.Linq;

namespace RefReturnSample
{
    ref struct MyStruct
    {
        public int X;
    }

    class SomeData
    {
        private int[] data = Enumerable.Range(0, 1000).ToArray();

        public ref readonly int GetDataByIndex(int index)
        {
            return ref data[index];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new SomeData();
            ref readonly int x = ref data.GetDataByIndex(400);
            // x = 42;
            Console.WriteLine(data.GetDataByIndex(400));

            MyStruct s1 = new MyStruct();
            s1.X = 42;
//            s1.ToString();
        }
    }
}
