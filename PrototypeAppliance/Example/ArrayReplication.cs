namespace PrototypeAppliance
{
    using System;
    using EasySharp.NHelpers.CustomExMethods;

    class ArrayReplication
    {
        public static void ClonArrayDemo()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] array2 = array1.CloneArray();

            Console.Out.WriteLine($"Elements in {nameof(array2)}:");

            foreach (int x in array2)
            {
                Console.Out.WriteLine("x = {0}", x);
            }
        }
    }
}