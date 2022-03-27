using System;
using System.Diagnostics;               //for stopwatch
using System.Threading;                 //for parallel loop
using System.Threading.Tasks;           //for parallel loop
using System.Globalization;
using System.Collections.Generic;       //for list
using System.Collections;               //for list
using System.Linq;                      //for list

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------
            //*****************lemda experation****************************************
            //********************LISTS************************************************
            //-------------------------------------------------------------------------
            
            var cusomerlist = new List<Customer>
            {
                new Customer{ Customercode = " 101", Customername = "john"},
                new Customer{ Customercode = " 102", Customername = "miky"},
                new Customer{ Customercode = " 103", Customername = "king"},
                new Customer{ Customercode = "104", Customername = "khan"}
            };

            //var result1 = cusomerlist.Find(a => a.Customercode == "102");
            
            //Console.WriteLine(result1);
            //var result2 = cusomerlist.Find(a => a.Customercode.Substring(0 , 1) == "1");
            //Console.WriteLine(result2);
            var result = cusomerlist.Select(c => c.Customercode).ToList();
            result.ForEach(c => Console.WriteLine(c) );


            //-------------------------------------------------------------------------
            //***************************  SWITCH CASE ********************************
            //-------------------------------------------------------------------------
            //Console.WriteLine("Enter user name");
            //string usname = Console.ReadLine();
            //usname = usname.ToLower();
            //if (usname == "admin")
            //{
            //    Console.WriteLine("Enter PAssword");
            //    int pass = int.Parse(Console.ReadLine());
            //    switch (pass)
            //    {
            //        case 123:
            //            Console.WriteLine("Logged in ");
            //            break;
            //        case 1234:
            //            Console.WriteLine("changed");

            //            break;
            //        default:
            //            Console.WriteLine("wrong password");
            //            break;
            //    }


            //--------------------------------------------------------------------------
            //************************  FOR LOOP ***************************************
            //--------------------------------------------------------------------------

            //Console.WriteLine("Enter user name");
            //string uname = Console.ReadLine();
            //if (uname == "admin")
            //{
            //    Console.WriteLine("enter your password");
            //    int pasword = int.Parse(Console.ReadLine());
            //    if (pasword == 123)
            //    {
            //        Console.WriteLine("Login successfully");
            //    }
            //    else
            //    {
            //        Console.WriteLine("you enter wrong password");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("wrong user name");
            //}

            //----------------------------------------------------------------------------
            // *******************parallel for loop***************************************
            //----------------------------------------------------------------------------

            //Stopwatch swach = new Stopwatch();
            //System.Diagnostics.Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //for (int i = 1; i < 12; i++)
            //{
            //    Thread.Sleep(5000);
            //}
            //stopwatch.Stop();
            //long time = stopwatch.ElapsedMilliseconds / 1000;
            //Console.WriteLine(time);
            //stopwatch.Reset();
            //stopwatch.Start();
            //Parallel.For(1, 12, i =>
            //{
            //    Thread.Sleep(5000);
            //});
            //stopwatch.Stop();
            //long time2 = stopwatch.ElapsedMilliseconds / 1000;
            //Console.WriteLine(time2);



            //----------------------------------------------------------------
            //*******************loops****************************************
            //----------------------------------------------------------------
            //Console.WriteLine("enter any number");
            //int j = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i * j);
            //}
            //int k = 0;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;

            //} while (k < 3);

            //}



            //end of main function
        }
    }
}

