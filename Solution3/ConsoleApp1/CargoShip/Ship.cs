namespace ConsoleApp1.CargoShip;

public class Ship
{
    public List<Container> containerList { get; set; }
    public int maxSpeed { get; set; }
    public int maxContainerAmount { get; set; }
    public int containerAmount { get; set; }
    public int maxContainerWeight { get; set; }
    public int containersWeight { get; set; }

    public void loadTheContainerToShip(Container container)
    {
        String containerID = container.number;
        int containerWeight = container.ownMass;

        if (this.maxContainerAmount >= this.containerAmount + 1)
        {
            if (maxContainerWeight >= containerWeight +containersWeight)
            {
                containerList.Add(container);
                containerAmount++;
                containersWeight += containerWeight;
            }
        }
    }

    public void loadContainerToAnotherShip(Container container,Ship nextShip)
    {
        containerList.Remove(container);
        nextShip.loadTheContainerToShip(container);
    }

    public void printContainerList()
    {
        for(int i=0;i<containerList.Count;i++){
            Console.WriteLine(containerList[i]);
        }
    }

    public void printShipInformation()
    {
        Console.WriteLine("Max speed of the ship : "+maxSpeed + ", Maxymalna liczba kontenerów : "+
                          maxContainerAmount+", Maxymalna waga kontenerow to (w kg): "+ maxContainerWeight+
                          ", Lista kontenerow przewozonych przez dany statek : ");
        printContainerList();
    }

    public void deleteContainerFromTheShip(Container container)
    {
        containerList.Remove(container);
    }
    
    
}