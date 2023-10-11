using System;
using System.Collections;//Non Generic
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class NonGenericDemo
    {
        static void Main(string[] args)
        {
            //WorkingWithStack();
            //WorkingWithQueue();
            //WorkingWithArrayList();

            //key value pairs where key will b unique but values can repeat, at such times
            //we use key value pair collections
            //Key value pair collections are :
            //Hashtable---nongeneric
            //SortedList
            //SortedDictionary

            //    Hashtable t=new Hashtable();    
            //key is converted to hashcode

            //SortedList---generic
            //data is sorted based on the key----ascending order data is kept/stored
            //uses a list

            //SortedDictionary--generic
            //data is sorted based on the key, uses a dictionary
            //Dictionary----generic


            //1---a
            //2---b
            //3---a
            Hashtable t = new Hashtable();
            t.Add(1, "Jim");
            t.Add(100, 'A');
            t.Add("1", 32234.33d);
            t.Add(2, 3.14f);
            t.Add(3, 122);

            
            foreach (DictionaryEntry item in t)
            {
                Console.WriteLine(item.Key + "   " + item.Value);
            }
            Console.WriteLine( "--------------");
            //Second way
            IDictionaryEnumerator ie=t.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "   " + ie.Value);

            }

            t.Remove(1);
            Console.WriteLine( "------");
            ie = t.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "   " + ie.Value);

            }
            Console.WriteLine("-----Show copied elements----- ");
            object[] objarr = new object[t.Count];
            t.CopyTo(objarr, 0);
            IEnumerator eObj=objarr.GetEnumerator();
            object o = null;
            while (eObj.MoveNext())
            {
                 o=eObj.Current;
              //  Console.WriteLine(o.);


            }




            Console.Read();

        }

        private static void WorkingWithArrayList()
        {
            int[] a = new int[2] { 12, 13 };
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(new DateTime(2023, 11, 10));

            string[] s1 = new string[] { "Hello", "Welcome" };
            ArrayList al = new ArrayList(s);
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.Add(1223);
            al.Add(new Product());

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.AddRange(a);//adds at the end
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.InsertRange(2, s1);//start inserting the s1 content from 2 index
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.Insert(10, "This is 10th index");
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.Remove(1223);//value can be passed that needs to be remvoed
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.RemoveRange(0, 2);//range can be specified, starting index and no of elements to remove
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            al.RemoveAt(0);//removes elemetn at particular index
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            //al.TrimToSize();
            //al.CopyTo();
            //al.ToArray();
            Console.WriteLine("a2 arraylist starts here...............");
            ArrayList a2 = new ArrayList();
            a2.Add(1);
            a2.Add(2);
            a2.Add(3);
            a2.Add(4);
            a2.Add(5);
            a2.Add(6);
            a2.Add(7);
            a2.Add(8);
            int[] myintArr = new int[] { 11, 22, 33, 44, 55 };

            a2.SetRange(1, myintArr);
            foreach (var item in a2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----RangeData----");

            ArrayList rangedata = a2.GetRange(1, 5);
            foreach (var item in rangedata)
            {
                Console.WriteLine(item);
            }
        }

        private static void WorkingWithQueue()
        {
            //fifo
            Queue q = new Queue(10);
            q.Enqueue(23);//add
                          // q.Dequeue();//remove
                          //for each loop is used to enumerate the q
            object ele = q.Peek(); // returns u the  first element
            int cnt = q.Count;//no of elements in the queue

            q.TrimToSize();
            q.Enqueue(34);
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


