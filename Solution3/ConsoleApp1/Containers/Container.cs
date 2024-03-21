namespace ConsoleApp1;

public class Container 
{
    public enum TypesOfContainer
    {
        Chlodniczy,
        Naplyny,
        NaGaz
    }
    
    public int loadMass {get; set; }
    public int height {get; set; }
    public int ownMass {get; set; }
    public int depth {get; set; }
    public string number {get; set; }
    public int maxLoad { get; set; }
    

    public void emptyTheCargo()
    { 
        this.loadMass = 0;
    }

    public void loadTheCargo(int mass)
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