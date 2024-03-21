namespace ConsoleApp1;

public class liquidContainer : Container
{
    public bool danger { get; set; }

    public void loadTheCargo(int massOfTheLoad)
    {
        if (danger)
        {
            if (massOfTheLoad > maxLoad)
            {
                throw new OverfillException("Toooooo heavy!!!!!!!!");
            }
            else if ()
            {
                
            }
        }
    }
}