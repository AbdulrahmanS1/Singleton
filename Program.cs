﻿using System;

namespace week6day2
{
    class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;
        
        //private static readonly object _lock = new object();
        public static Singleton GetInstance(string value)
        {
            return _instance ??= new Singleyon();
            
            // if (_instance == null)
            // {
                
            //     lock (_lock)
            //     {
                    
            //         if (_instance == null)
            //         {
            //             _instance = new Singleton();
            //             _instance.Value = value;
            //         }
            //     }
            // }
            // return _instance;
        }
       
        public string Value { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "If you see the same value, then singleton was reused (yay!)",
                "If you see different values, then 2 singletons were created (booo!!)",
                "RESULT:"
            );

            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2){
                Console.WriteLine("all good");
            }
            else
            {
                Console.WriteLine("something wrong");
            }

            // Thread process1 = new Thread(() =>
            // {
            //     TestSingleton("FOO");
            // });
            // Thread process2 = new Thread(() =>
            // {
            //     TestSingleton("BAR");
            // });
            // process1.Start();
            // process2.Start();
            // process1.Join();
            // process2.Join();
        }
        // public static void TestSingleton(string value)
        // {
        //     Singleton singleton = Singleton.GetInstance(value);
        //     Console.WriteLine(singleton.Value);
        // } 
    }
}
