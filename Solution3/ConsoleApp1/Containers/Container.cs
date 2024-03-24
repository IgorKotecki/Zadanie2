using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class Container : IContainer
{
    public int loadMass { get; set; }
    public int height { get; set; }
    public int ownMass { get; set; }
    public int depth { get; set; }
    
    public int maxLoad { get; set; }
    public ContainerType containerType { get; set; }
    public string number;
    public Container()
    {
        number = "KON-";
    }
    public virtual void emptyTheCargo()
    { 
        this.loadMass = 0;
    }

    public virtual void loadTheCargo(int mass)
    {
        if (mass > this.loadMass) 
        { 
            throw new OverfillException("Load mass is to high!!!!");
        }
        else
        { 
            this.loadMass = mass;
        }

    }


    
}