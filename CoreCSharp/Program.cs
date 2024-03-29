﻿using CSharpSamples;
using CSharpSamples.Attributes;
using CSharpSamples.CodeFirstApproach;
using CSharpSamples.Delegate;
using CSharpSamples.DSAndAlgorithms.Algorithms;
using CSharpSamples.DSAndAlgorithms.BST;
using CSharpSamples.DSAndAlgorithms.LinkedList;
using CSharpSamples.EventDrivenArchitecture;
using CSharpSamples.ExtensionMethods;
using CSharpSamples.LINQ;
using CSharpSamples.Operators;
using CSharpSamples.OOP;
using CSharpSamples.RecursiveFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.Clear();
                Console.WriteLine("-- Start of Program --");
                Console.WriteLine("1. Method Extensions");
                Console.WriteLine("2. EF code first approach");
                Console.WriteLine("3. Generic functions and binary search");
                Console.WriteLine("4. SLL");
                Console.WriteLine("5. DLL");
                Console.WriteLine("6. BST");
                Console.WriteLine("7. Operator Overloading");
                Console.WriteLine("8. Delegates");
                Console.WriteLine("9. Attributes");
                Console.WriteLine("10. Event Driven Architecture");
                Console.WriteLine("11. LINQ");
                Console.WriteLine("12. Algorithms");
                Console.WriteLine("13. OOP Concepts");
                Console.Write("Enter your choice : ");
                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);
                IProgram program;
                switch (choice)
                {
                    case 1:
                        //MethodExtensions
                        program = new MethodExtensionProgram();
                        break;
                    case 2:
                        //EFCodeFirstApproach(); //EFProgram
                        program = new EFProgram();
                        break;
                    case 3:
                        //RecursiveFunctions(); // RFProgram
                        program = new RFProgram();
                        break;
                    case 4:
                        //SLL(); //SLLProgram
                        program = new SLLProgram();
                        break;
                    case 5:
                        //DLL();
                        program = new DLLProgram();
                        break;
                    case 6:
                        //BST();
                        program = new BSTProgram();
                        break;
                    case 7:
                        program = new OperatorProgram();
                        break;
                    case 8:
                        //Delegates Program
                        program = new DelegateProgram();
                        break;
                    case 9:
                        // Attributes Program
                        program = new AttributeProgram();
                        break;
                    case 10:
                        // Event Driven Architecture Program
                        program = new EDAProgram();
                        break;
                    case 11:
                        // LINQ Program
                        program = new LINQProgram(); 
                        break;
                    case 12:
                        // Algorithms Program
                        program = new AlgorithmProgram(); 
                        break;
                    case 13:
                        // OOP Program
                        program = new OOPProgram();
                        break;
                    default:
                        //Exit the application
                        program = null;
                        Console.WriteLine("Exiting program");
                        Environment.Exit(-1);
                        break;
                }

                program?.Run();

                Console.WriteLine("-- End of Program --");
                Console.ReadKey();
                Console.WriteLine(" Click any key to proceed ");
            }
        }
    }
}
