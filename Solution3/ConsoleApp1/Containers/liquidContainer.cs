using ConsoleApp1.Interfaces;

namespace ConsoleApp1;


public class liquidContainer : Container,IHazardNotifier,IContainer
{
    //dziedziczenie po interfejsie Icontainer
    public static int Index{ get; set; }
    public int loadMass { get; set; }
    public int height { get; set; }
    public int ownMass { get; set; }
    public int depth { get; set; }
    public int maxLoad { get; set; }
    public ContainerType containerType { get; set; }
    //wlasne zminne klasy
    public bool danger;
    private static int liquidIndex = 1;
    public string number { get;}
    
    public liquidContainer()
    {
        number = "KON-L-" + liquidIndex;
        liquidIndex++;
    }

    public override void loadTheCargo(int massOfTheLoad)
    {
        if (loadMass > 0)
        {
            throw new Exception("The container already has load in it!");
        }
        else if (massOfTheLoad > maxLoad)
        {
            throw new Exception("Mass of the lode is to big!");
        }
        else
        {
            if (danger)
            {
                if (massOfTheLoad > maxLoad*0.5)
                {
                    this.loadMass = maxLoad / 2;
                }
                else
                {
                    this.loadMass = massOfTheLoad;
                }
            }
            else
            {
                if (massOfTheLoad > maxLoad * 0.9)
                {
                    this.loadMass = (maxLoad * (9/10));
                }
                else
                {
                    this.loadMass = massOfTheLoad;
                }
            }
        }

        
    }

    public override void emptyTheCargo()
    {
        loadMass = 0;
    }
}