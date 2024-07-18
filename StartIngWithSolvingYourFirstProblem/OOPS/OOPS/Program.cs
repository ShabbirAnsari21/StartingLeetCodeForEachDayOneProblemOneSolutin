// Polymorphism

//a single persone can behave as adiffrent type in a diffrent place 
//a boy can be a student or a son or a bestfriend

//code for this

//there are two type of polymorphism 1st run time polymorphism using override
//second one is overloading

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void Method()
    {
        Console.WriteLine("Method");
    }
}

public class Boy : Student
{
    public override void Method()
    {
        Console.WriteLine("Boy");
    }
}
public class Girl : Student
{
    public override void Method()
    {
        Console.WriteLine("Girl");
    }
}

public class MainClass
{
    public static void Main1(string[] args)
    {
        Student boy = new Boy();
        // at the student type of variable if i am storing boy type of object than it will behave like a boy
        boy.Name = "shabbir";
        boy.Method();
        Console.WriteLine("at the student type of variable if i am storing boy type of object than it will behave like a boy");
    }
}