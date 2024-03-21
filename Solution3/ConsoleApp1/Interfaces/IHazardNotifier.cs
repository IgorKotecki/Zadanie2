namespace ConsoleApp1.Interfaces;

public interface IHazardNotifier
{
    public void Notification(string containerID)
    {
        Console.WriteLine("Dangerous situation, container ID : "+ containerID);
    }
}