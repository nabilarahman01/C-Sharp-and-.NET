using System;

namespace Lab1
{
    public class OverRidingImplementation : OverRiding
    {
        string name1;
        public void ImplementOverRiding()
        {
            int result = Sum(30, 20);

            Console.WriteLine("After OverRiding. " + result);
            //Console.ReadLine();
        }

        public override int Sum(int num1, int num2)
        {
            return num1 * num2;
        }

        public override void setStudent(string name)
        {
            name1 = name;
        }

        public override string getStudent() 
        {
            return "20200204065 " + name1;
        }
    }
}