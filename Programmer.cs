using PrintProgrammer.Interfaces;

namespace PrintProgrammer;

public class Programmer : IProgrammer
{
    public void WakeUp() => Console.WriteLine("Param pam pam! Hello caffeine!");
    public void Sleep() => Console.WriteLine("Zzzzzz....");
    public bool IsDead { get; set; }
    public void Code() => Console.WriteLine("Hello caffeine");

    public void CallMyWife() => Console.WriteLine("I love you! See you");

    public void Commit() => Console.WriteLine("add: By-by");
}