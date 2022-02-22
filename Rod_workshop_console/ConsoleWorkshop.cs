using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDLL;

namespace Rod_workshop_console
{
    internal class ConsoleWorkshop
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Rodney Taylor",1000000.01);
            account.Debit(45000);
            account.Credit(110000);
            Console.WriteLine("Rod's account balance now = £{0}",account.Balance);

            Console.ReadLine();


            //// ==============================================================================


            //Printer printer = new Printer();
            //Console.WriteLine(printer.ToString());

            //// ==============================================================================
            //int[] myArray1 = { 1, 2, 3}; // 1st syntax
            //// Print myArray1
            //for (int i = 0; i < myArray1.Length; i++)
            //{
            //    Console.WriteLine("myArray1[{0}] = {1}", i, myArray1[i]);
            //}
            //Console.WriteLine("===========================================");

            //int[] myArray2 = new int[] { 1, 2, 3 }; // 2nd syntax
            //// Print myArray2
            //for (int i = 0; i < myArray2.Length; i++)
            //{
            //    Console.WriteLine("myArray2[{0}] = {1}", i, myArray2[i]);
            //}
            //Console.WriteLine("===========================================");

            //int[] myArray3 = new int[3]; // 3rd syntax
            //myArray3[0] = 1;
            //myArray3[1] = 2;
            //myArray3[2] = 3;
            //// Print myArray3
            //for (int i = 0; i < myArray3.Length; i++)
            //{
            //    Console.WriteLine("myArray3[{0}] = {1}", i, myArray3[i]);
            //}
            //Console.WriteLine("===========================================");

            //int[,] myArray4 = new int[2,2]; // Multi-dimensional array
            //myArray4[0, 0] = 1;
            //myArray4[0, 1] = 2;
            //myArray4[1, 0] = 3;
            //myArray4[1, 1] = 4;
            //// Print myArray4: notice the use of GetLength(n) to access 
            //// specific dimension of the multi-dimensional array
            //for (int i = 0; i < myArray4.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myArray4.GetLength(1); j++)
            //    {
            //        Console.WriteLine("myArray4[{0},{1}] = {2}", i, j, myArray4[i, j]);
            //    }
            //}
            //Console.WriteLine("===========================================");



            //Grandchild grandchild = new Grandchild(2);

            //Console.WriteLine(Calculation.Add(1, 2, 3, 5));




            //NonAbstractChild nonAbstractChild = new NonAbstractChild();
            //nonAbstractChild.Speak("Hi there!");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }

        static int Add(params int[] userInputs)
        {
            int sum = 0;

            for (int i = 0; i < userInputs.Length; i++)
            {
                sum += userInputs[i];
            }

            return sum;
        }
    }


    public class Printer
    {
        string message;

        public Printer()
        {
            message = "Welcome, Rod!";
        }
        public override string ToString()
        {
            return message;
        }
    }

    public class Parent
    {
        protected int age;
        public Parent()
        {
            Console.WriteLine("This is Parent() constructor");
        }
    }

    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("This is Child() constructor");
        }

        public Child(int age)
        {
            Console.WriteLine($"This is Child({age}) constructor");
        }
    }

    public class Grandchild : Child
    {

        public Grandchild()
        {
            Console.WriteLine("This is Grandchild() constructor");
        }

        public Grandchild(int age) : base(age+40) // This will call the Child(int age) constructor instead
        {
            Console.WriteLine($"This is Grandchild({age}) constructor");
        }
    }

    public abstract class AbstractParent
    {
        private string greetings = "I am an AbstractParent";

        public AbstractParent()
        {
            Console.WriteLine(greetings);
        }

        public abstract void Speak(string message);
    }

    public class NonAbstractChild : AbstractParent
    {
        public override void Speak(string message)
        {
            Console.WriteLine($"This is NonAbstractChild speaking: \"{message}\"");
        }
    }

    public interface IAnimal
    {

    }
}
