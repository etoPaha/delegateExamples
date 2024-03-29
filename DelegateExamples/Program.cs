﻿using System;
using DelegateExamples.ActionPredicateFunc;

namespace DelegateExamples
{
    class Program
    {
        private static void BasicDelegateExamples()
        {
            Console.WriteLine(new string('-', 40));
            
            SimpleDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            OperationDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            MultipleMethodsInDelegate.Run();
            
            Console.WriteLine(new string('-', 40));
            
            CombineDelegates.Run();
            
            Console.WriteLine(new string('-', 40));
            
            UseInvokeExample.Run();
            
            Console.WriteLine(new string('-', 40));
            
            ManyOperationsInDelegate.Run();

            Console.WriteLine(new string('-', 40));
            
            DelegateAsParameter.Run();

            Console.WriteLine(new string('-', 40));
            
            GenericDelegate.Run();
        }
        
        static void Main(string[] args)
        {
            // 1
            //BasicDelegateExamples();
            
            // 2
            //AccountExample.AccountExample.Run();
            
            // 3
            //ActionExample.Run();
            
            // 4
            //PredicateExample.Run();
            
            // 5
            // FuncExample.Run();
            
            // 6
            EventExample.EventExample.Run();
            
            Console.ReadLine();
        }
    }
}