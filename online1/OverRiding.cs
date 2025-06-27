using System;

namespace Lab1
{
    public class OverRiding
    {
        
        public virtual void ExploreOverRiding()
        {
            var result = Sum(10, 20);

            Console.WriteLine("Before Method OverRiding: " + result);
            //Console.ReadLine();
        }

        //To perform method overriding in C#, 
        //you need to use virtual keyword with base class method 
        //and override keyword with derived class method.
        public virtual int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public virtual void setStudent(String name)
        {
            
        }
        public virtual string getStudent()
        {
            return string.Empty;
        }

    }
}