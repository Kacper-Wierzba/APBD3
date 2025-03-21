namespace APBD3;

public abstract class Kontener
{
    abstract public float MassWithCargo{set; get;}
    abstract public float MassOfContener{set; get;}
    abstract public float Height{set; get;}
    abstract public float Depth{set; get;}
    abstract public float MaxVolumeInKg{set; get;}

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
    
    abstract public void Empty();
    abstract protected void Zaladunek();

    private void DontOverflow(float Mass)
    {
        if(Mass>MaxVolumeInKg)
            throw new OverfillException("Maximum volume is " + MaxVolumeInKg);
    }
    
    public void Fill(float Mass)
    {
        DontOverflow(Mass);
        Zaladunek();
    }
    
}