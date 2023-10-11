using System;


namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 100, 13, 134, 5,6,1, 278,1235, 899, 9333 };
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            //Array.Reverse(arr);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr);//default----in ascending order
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-------------------------");
            //Array.Reverse(arr);//reverse the sorted  array to get descending order
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------");
            //Array.Clear(arr, 2, 5);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine( item);
            //}
            //Console.WriteLine("---------------------");
            //Array.Resize(ref arr, 9);
            ////arr[10] = 100;
            //foreach (var item in arr) {
            //    Console.WriteLine(  item);
            //}

            // Console.WriteLine("------------------------");
            //    Array.Sort(arr);
            //int indexOfelement= Array.BinarySearch(arr, 899);
            // Console.WriteLine(  indexOfelement);
            //Console.WriteLine(  "----------------------");
            //int[] newarr = new int[5];
            //Array.Copy(arr, newarr, arr.Length);//copies all elements
            //Array.Copy(arr, newarr, 5);

            //foreach (var item in newarr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------");

            int[] arr1 = (int[])arr.Clone();
            foreach (var item in arr1) 
            { 
                Console.WriteLine(item);
            }


            //string[] names = new string[] { "Sumit", "Babita", "Zeeshan", "Amita", "Ankita", "Sunita" };
            //Array.Sort(names);
            //foreach (var item in names)
            //{
            //    Console.WriteLine( item);
            //}


            Console.Read();

        }
    }
}
