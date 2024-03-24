namespace ConsoleApp1;

class Start
{
    static void Main(string[] args)
    {
        
        List<Object> kontenery = new List<object>();
        kontenery.Add(new liquidContainer(){containerType = ContainerType.Liquid,danger = true,
                                                depth = 10,height = 5,loadMass = 100,maxLoad = 110});

        liquidContainer l = new liquidContainer()
        {
            containerType = ContainerType.Liquid, danger = true,
            depth = 10, height = 5, loadMass = 100, maxLoad = 110
        };
        liquidContainer l2 = new liquidContainer()
        {
            containerType = ContainerType.Liquid, danger = true,
            depth = 10, height = 5, loadMass = 100, maxLoad = 110
        };
        
        l.emptyTheCargo();
        l.loadTheCargo(101);
        l.loadTheCargo(1);
        Console.WriteLine(l.loadMass);

        coolingContainer c = new coolingContainer();
        
        
    }
}