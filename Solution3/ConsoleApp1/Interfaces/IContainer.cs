namespace ConsoleApp1.Interfaces;

public interface IContainer
{
    public static int Index{ get; set; }
    public int loadMass { get; set; }
    public int height { get; set; }
    public int ownMass { get; set; }
    public int depth { get; set; }
    public int maxLoad { get; set; }
    public ContainerType containerType { get; set; }
}