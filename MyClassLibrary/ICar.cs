namespace MyClassLibrary
{
    public class Icar
    {
       
        
            public int GetPrice(String name)
            {
                if (name == "i10")
                {
                    return 2000000;
                }
                else if (name == "i20")
                {
                    return 2500000;
                }
                else
                    return 1500000;
            }

        

    }
}