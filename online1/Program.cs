using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var print = new Print();
            //print.DoPrint();

            //var numbers = new Numbers();
            //numbers.PlayWithNumbers();

            //var ifElse = new IfElse();
            //ifElse.ExploreIfElse();

            //var loops = new Loops();
            //loops.ExploreLoops();

            //var lists = new Lists();
            //lists.ExploreLists();

            //IOOP studentInfo = new OOP();
            //studentInfo.StudentInfo();

            //var valueVsReference = new ValueVsReference();
            //valueVsReference.ExploreValueVsReferenceType();

            //var overRiding = new OverRiding();
            //overRiding.ExploreOverRiding();

            var overridingimplementation = new OverRidingImplementation();
            overridingimplementation.ExploreOverRiding();
            overridingimplementation.ImplementOverRiding();
            overridingimplementation.setStudent("nabila");
            Console.WriteLine(overridingimplementation.getStudent());

            //var generic = new Generic();
            //generic.ExploreGeneric();
        }
    }
}
