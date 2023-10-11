using System;
using System.Collections;//Non Generic
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class NonGenericDemo
    {
        static void Main(string[] args)
        {
            //WorkingWithStack();

            Console.Read();

        }

        private static void WorkingWithStack()
        {
            //ICollection ----copyto,size
            //IEnumerble----foreach loop functionality---iteration,enumeration
            //ICloneable----clone
            //NonGeneric---any datatype can be stored
            //LIFO-----Last in First Out
            Stack s = new Stack(5);
            s.Push(1);
            s.Push(89.33f);
            s.Push("India");
            s.Push("true");
            s.Push(new DateTime(2023, 09, 11));
            s.Push(89.3233d);
            Product p = new Product();
            p.Prodid = 1;
            p.ProdName = "Abc";
            p.Price = 888;
            s.Push(p);
            object o = 34509;
            s.Push(o);
            s.Push(p.Prodid);
            s.Push(p.ProdName);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------");
            object o1 = s.Peek();//return top most element
            Console.WriteLine("The top most element =" + o1);
            Console.WriteLine("---------------------------");
            o1 = s.Pop();
            Console.WriteLine("Pop/removed the top most element " + o1);
            Console.WriteLine("-------------------");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------");
            bool ans = s.Contains("India");
            Console.WriteLine("Yes it contains = " + ans);
            Stack s1 = new Stack();

            foreach (object item in s)
            {
                string s2 = "India";
                if (item.ToString() != s2)
                {
                    s1.Push(item);
                }
            }

            Console.WriteLine("------s1 stack elements-----");
            foreach (var item in s1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=------- s stack eleemtns");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}


