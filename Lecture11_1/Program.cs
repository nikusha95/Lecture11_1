// See https://aka.ms/new-console-template for more information

using Lecture11_1;


//IndexOutOfRangeException
//ArgumentOutOfRangeException
//NullReferenceException
//DivideByZeroException
try
{
    Person p = new Person("firstName", "lastName", DateTime.Now.AddYears(-20));
    Person p1 = null;
    p.FirstName = "aaa";
    p.Age = 12;
    int y = 19;
    int z = 0;
    int k = y / z;
    Console.WriteLine($"{p.FirstName} {p.LastName} {p.Age}");
    p1.FirstName = "nika";
}
catch (NullReferenceException ex)
{
    Console.WriteLine(ex.Message);
}
catch (DivideByZeroException e)
{
    Console.WriteLine(e.Message);
}
catch (AgeOutOfRangeException ex)
{
    Console.WriteLine(ex.Details);
}
catch (Exception e)
{
    Console.WriteLine($" general exception {e.Message}");
}
finally
{
    Console.WriteLine("finally block");
}

const int x = 10;
Console.WriteLine(x);