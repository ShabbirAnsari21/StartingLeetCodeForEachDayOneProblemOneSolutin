using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class PolyMorphysm
    {
        // a single thing can behave in a multiple way 
        // ex a boy is a son of some one and friend, and student

        // there are two type of polymorphysm
        // runtime 
        // complietime 

        // for runtime derived class has the same method name and signature as base class

        // example code
        #region for runtime polymorphism
        //public class ParentClass
        //{
        //    public virtual void Name()
        //    {
        //        Console.WriteLine("Shabbir");
        //    }
        //}

        //public class ChildClass : ParentClass
        //{
        //    public override void Name()
        //    {
        //        Console.WriteLine("Ansari");
        //    }
        //}

        #endregion

        // example code
        #region for compile time polymorphism

        //public int sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public int sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        #endregion


        static void MainN(string[] args)
        {
            ParentClass obj = new ParentClass();
            obj.Name();
            ParentClass obj2 = new ChildClass();
            obj2.Name();

            ChildClass obj3 = new ChildClass();

            Console.WriteLine(obj3.sum(2, 3));
            Console.WriteLine(obj3.sum(3, 4, 5));
        }

    }
    public class ParentClass
    {
        public virtual void Name()
        {
            Console.WriteLine("Shabbir");
        }
    }

    public class ChildClass : ParentClass
    {
        public override void Name()
        {
            Console.WriteLine("Ansari");
        }


        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sum(int a, int b, int c)
        {
            return a +b+c;
        }
    }
}
