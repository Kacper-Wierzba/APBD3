namespace APBD3;

public abstract class Kontener
{
    public float MassWithCargo{set; get;}
    public float MassOfContener{set; get;}
    public float Height{set; get;}
    public float Depth{set; get;}
    public float MaxVolumeInKg{set; get;}

    protected string SerialNumber
    {
        set
        {
            SerialNumber = "KON-"+value+"-"+Kontener.nextNum;
        }
        get
        {
            return SerialNumber;
        }
    }
    private static int nextNum
    {
        set
        {
            throw new Exception("cant change automated filed");
        }
        get
        {
            return nextNum++;
        }
    }
    
    

}