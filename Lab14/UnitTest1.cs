using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using System.Threading;

namespace Lab14
{
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }

    [TestClass]
    public class PrintInOrderTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Foo foo = new Foo();
            Thread a = new Thread(foo.first);
            Thread b = new Thread(foo.second);
            Thread c = new Thread(foo.third);

            a.Start();
            b.Start();
            c.Start();
            a.Join();
            b.Join();
            c.Join();
        }
        [TestMethod]
        public void TestMethod2()
        {
            Foo foo = new Foo();
            Thread a = new Thread(foo.first);
            Thread b = new Thread(foo.third);
            Thread c = new Thread(foo.second);

            a.Start();
            b.Start();
            c.Start();
            a.Join();
            b.Join();
            c.Join();
        }

        [TestMethod]
        public void TestMethod3()
        {
            for (int i = 0; i < 100; i++)
            {
                Foo foo = new Foo();
                Thread[] t = new Thread[3] { new Thread(foo.first), new Thread(foo.second), new Thread(foo.third) };
                
                var rng = new Random();
                rng.Shuffle(t);
                foreach (Thread k in t)
                {
                    k.Start();
                }
                foreach (Thread k in t)
                {
                    k.Join();
                }
                Console.WriteLine();
            }
        }
    }
}
