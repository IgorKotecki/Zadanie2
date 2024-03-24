using ConsoleApp1.Interfaces;

namespace ConsoleApp1;

public class coolingContainer : Container,IContainer
{
    //dziedziczenie po interfejsie Icontainer
    public static int Index{ get; set; }
    public int loadMass { get; set; }
    public int height { get; set; }
    public int ownMass { get; set; }
    public int depth { get; set; }

    public string number { get; set; }
    public int maxLoad { get; set; }
    public ContainerType containerType { get; set; }
    //własne zmienne tej klasy
    public string typeOfItem { get; set; }
    public int temperature { get; set; }
    public int tempOfItem { get; set; }
    private static int coolingIndex = 1;

    public coolingContainer()
    {
        number = "KON-C-" + coolingIndex;
        coolingIndex++;
    }
    
    public bool chceckIfTypeSame(string type)
    {
        return this.typeOfItem.Equals(type);
    }
    
    
}