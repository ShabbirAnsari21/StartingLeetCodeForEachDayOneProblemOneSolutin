namespace OOPS
{
    internal class Inheritance
    {
        static void Main2(string[] args)
        {
            child child = new child();
            child.FirstName = "Test";
            child.NameWithSirName();

            Console.Write(child.FirstName);
            child.NameWithSirName();
            Console.ReadLine();
        }
    }

    // inheritance is creating parent child relationship 
    // were child will get the property of parent automaticly
    //Ex

    //Single level inheritance
    public class parent
    {
        public string SirName { get; set; }
        public void NameWithSirName() 
        {
            Console.WriteLine("SirName");
        }
    }
    public class child : parent 
    {
        public string FirstName { get; set; }

    }

    // multilevel inheritance

    public class parent1
    {
        public void NameWithSirName() 
        {
            Console.WriteLine("SirName");
        }
    }
    public class child1 : parent1 
    {
        public void NameWithFirstName()
        {
            Console.WriteLine("FirstName");
        }
    }
    public class child2 : child1
    {
        public void NameWithLastName()
        {
            Console.WriteLine("LastName");
        }
    }

    public class MainClass
    {
        public static void Main3(string[] args)
        {
            child2 child = new child2();
            child.NameWithFirstName();
            child.NameWithLastName();
            child.NameWithSirName();
            Console.ReadLine();
        }
    }

    // multiple inheritance 
}
