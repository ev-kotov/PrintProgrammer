namespace PrintProgrammer.Interfaces;

public interface IHuman
{
    public void WakeUp();
    public void Sleep();
    public bool IsDead { get; set; }
}