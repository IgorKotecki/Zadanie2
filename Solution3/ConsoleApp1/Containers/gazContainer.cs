using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class gazContainer : Container,IHazardNotifier,IContainer
{
    //dziedziczenie po interfejsie Icontainer
    public static int Index{ get; set; }
    public int loadMass { get; set; }
    public int height { get; set; }
    public int ownMass { get; set; }
    public int depth { get; set; }
    
    public int maxLoad { get; set; }
    public ContainerType containerType { get; set; }
    //własne zmienne tej klasy
    public int pressure { get; set; }
    public string number { get; }
    private static int gazIntex = 1;

    public gazContainer()
    {
        number = "KON-G-" + gazIntex;
        gazIntex++;
    }

    public void emptyTheCargo()
    {
        this.ownMass = this.ownMass * (5 / 100);
    }

    public void loadTheCargo(int mass)
    {
        if (mass > this.maxLoad)
        {
            throw new OverfillException("The amount of gaz is to big to load!");
        }
        else
        {
            this.ownMass = mass;
        }
    }

    public void Notification()
    {
        Console.WriteLine("Dangerous situation, Container ID "+ this.number);
    }
}