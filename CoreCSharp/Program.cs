using CSharpSamples.CodeFirstApproach;
using CSharpSamples.DSAndAlgorithms.BST;
using CSharpSamples.DSAndAlgorithms.LinkedList;
using CSharpSamples.ExtensionMethods;
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
                Console.WriteLine("-- Start of Program --");
                Console.WriteLine("1. Method Extensions");
                Console.WriteLine("2. EF code first approach");
                Console.WriteLine("3. Generic functions and binary search");
                Console.WriteLine("4. SLL");
                Console.WriteLine("5. DLL");
                Console.WriteLine("6. BST");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        MethodExtensions();
                        break;
                    case 2:
                        EFCodeFirstApproach();
                        break;
                    case 3:
                        RecursiveFunctions();
                        break;
                    case 4:
                        SLL();
                        break;
                    case 5:
                        DLL();
                        break;
                    case 6:
                        BST();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("-- End of Program --");
                Console.WriteLine("  ");
            }
        }

        static void MethodExtensions()
        {
            Employee emp = new Employee();
            emp.Name = "Hai I am an string";
            Console.WriteLine(emp.ToString());
            Console.WriteLine("Length: " + emp.StringLength());

            string str = "Hai I am an string";
            Console.WriteLine(str);
            Console.WriteLine("Spaces: " + str.Spaces());

            ITest test = new Test();
            test.Dummy();

            List<int> set = new List<int>();
            set.Dummy<int>();
        }

        static void EFCodeFirstApproach()
        {
            using (var context = new EFDbContext())
            {
                //context.Database.sq
                context.Database.Delete();
                context.Database.Create();
            }
        }

        static void RecursiveFunctions()
        {
            List<int> set = new List<int>();
            int valueToFind = 8;
            for (int i = 0; i < 10; i++)
            {
                set.Add(i + 1);
            }
            set.GetSubsets();
            Console.WriteLine("Index of {0} is {1}", valueToFind, set.BinaryASearch(valueToFind));
            
            string namesString = "KJDS SRINIVASA RAOa";
            char nameToFind = 'a';
            namesString.ToCharArray().ToList();

            Console.WriteLine("Index of {0} is {1}", nameToFind.ToString(), namesString.ToCharArray().ToList().BinaryASearch(nameToFind));

        }

        static void SLL()
        {
            Console.WriteLine("-- Singly Linked List --");
            SinglyLL<int> sll = new SinglyLL<int>();
            for (int i = 1; i <= 10; i++)
            {
                sll.Add(i);
            }
            sll.Print();
            Console.Write("Enter value to search: ");
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sll.Contains(item));
            Console.Write("Enter value to delete: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sll.Delete(item));
            sll.Print();
        }

        static void DLL()
        {
            int item;
            Console.WriteLine("-- Doubly Linked List --");
            DoublyLinkedList<int> dll = new DoublyLinkedList<int>();
            for (int i = 1; i <= 10; i++)
            {
                dll.Add(GenerateRandom());
            }
            dll.Print();
            Console.Write("Enter value to search: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contains {0} : {1}", item, dll.Contains(item));
            Console.Write("Enter value to delete: ");
            item = Convert.ToInt32(Console.ReadLine());
            dll.Delete(item);
            dll.Print();
        }

        static void BST()
        {
            Console.WriteLine("-- BST --");
            int item;
            BST<int> bst = new BST<int>();
            for (int i = 1; i <= 10; i++)
            {
                //bst.Add(GenerateRandom());
                bst.Add(i);
            }
            bst.Print();
            Console.Write("Enter value to search: ");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Contains {0} : {1}", item, bst.Contains(item));
        }

        public static int GenerateRandom()
        {
            //if(this.GetType() ==  )
            //{
            //    return new Random().Next();
            //}
            var rand = new Random();
            return rand.Next(1, 999);
        }
    }
}
