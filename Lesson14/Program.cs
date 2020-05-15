using System;
using System.Collections;
using System.Linq;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region      HashTable class

            //Hashtable hash = new Hashtable();

            //Console.WriteLine("--------------------- Hashtable class add method -----------------");
            //hash.Add("c#", "Microsoft");
            //hash.Add("java", "corporate sun");
            //hash.Add("oracle", "corporate sun oracle");
            //hash.Add("ms sql", "microsoft ms sql");
            //Console.WriteLine();

            //Console.WriteLine("-------------------- Hashtable class keys prop --------------------");
            //var keys = hash.Keys;
            //foreach (var item in keys)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("-------------------- Hashtable class values prop");
            //var values = hash.Values;

            //foreach (var item in values)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------------- Hashtabe containskey method ------------------");

            //if (hash.ContainsKey("c#"))
            //{
            //    Console.WriteLine("c# key is found hashtable");
            //}
            //else
            //{
            //    Console.WriteLine("Key is not found ");
            //}


            //Console.WriteLine();
            //Console.WriteLine("---------------------- Hashtable containtValue method -----------------");
            //if (hash.ContainsValue("soft"))
            //{
            //    Console.WriteLine("soft - values is found");
            //}
            //else
            //{
            //    Console.WriteLine("Soft values if not found");
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------------- hashtable copy to method -------------------");


            ////string[] objArray = new string[hash.Count];
            ////hash.CopyTo(objArray, 0);

            //Console.WriteLine();
            //Console.WriteLine("--------------------------- hashtable remote method  -----------------------");
            //hash.Remove("java");

            //foreach (DictionaryEntry item in hash)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Clear hashtable");
            //hash.Clear();
            //Console.WriteLine("hashtable element count  =" + hash.Count);


            //Console.WriteLine("--------------- Hashtable contains method -----------s");

            //if (hash.Contains(null))
            //{
            //    Console.WriteLine("");
            //}

            #endregion   HashTable class

            #region     Queue class

            //    Queue que = new Queue();

            //    que.Enqueue(1);
            //    que.Enqueue(2);
            //    que.Enqueue(3);
            //    que.Enqueue(4);
            //    que.Enqueue(5);

            //    /*
            //     IN
            //     ---------------------------------
            //(LILO)5      4       3       2       1(FIFO)
            //     ---------------------------------
            //                                    OUT
            //     */

            //    Console.WriteLine("Queue count is = " + que.Count);


            //    for (int i = 0; i < que.Count + i; i++)
            //    {
            //        //Console.WriteLine("Queue element count is = " + que.Count);
            //        Console.WriteLine(que.Dequeue());
            //    }

            //    if (que.Contains("3"))
            //    {
            //        Console.WriteLine("3 is found queue");
            //    }
            //    else
            //    {
            //        Console.WriteLine("is not found");
            //    }


            //    Console.WriteLine("------------ To Array method------------");
            //    object[] obj = que.ToArray();

            //    foreach (var item in obj)
            //    {
            //        int currentNumber = (int)item;
            //        Console.WriteLine(currentNumber);
            //    }


            #endregion  Queue class

            #region      Stack class

            //Stack stc = new Stack(0);

            //Console.WriteLine("Push added to stack");
            //stc.Push(1);
            //stc.Push(4);
            //stc.Push(5);
            //stc.Push(7);


            ///*

            //  |    7    | (LIFO) (PEEK, TAIL)
            //  |_________|
            //  |    5    |
            //  |_________|
            //  |    4    |
            //  |_________|
            //  |    1    |  (FILO)
            //  |_________|   

            // */


            //Console.WriteLine("Stack elements");
            //foreach (var item in stc)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("Stack element pop");

            //for (int i = 0; i < stc.Count + i; i++)
            //{
            //    Console.WriteLine(stc.Pop());
            //}


            //string text = "madam";

            //string reverseText = string.Empty;


            //stc.Clear();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    stc.Push(text[i]);
            //}


            //for (int i = 0; i < stc.Count + i; i++)
            //{
            //    reverseText += stc.Pop();
            //}


            //Console.WriteLine(text.Equals(reverseText) ? "Polindrome" : "Not polindrome");




            #endregion   Stack class

            #region       SortedList class



            #endregion   SortedList class


            Console.ReadKey();
        }
    }
}
