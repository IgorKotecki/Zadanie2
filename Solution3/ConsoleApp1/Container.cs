namespace ConsoleApp1;

public class Container 
{
    public enum TypesOfContainer
    {
        Chlodniczy,
        Naplyny,
        NaGaz
    }

    public class Container
    {
        public int loadMass {get; set; }
        public int height {get; set; }
        public int ownMass {get; set; }
        public int depth {get; set; }
        public string number {get; set; }
        public int maxLoad { get; set; }

        public Container(int loadMass,int height,int ownMass,int depth,string number,int maxLoad)
        {
            loadMass = loadMass;
            height = height;
            ownMass = ownMass;
            depth = depth;
            number = number;
            maxLoad = maxLoad;
        }

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
    
}