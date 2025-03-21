using System.Runtime.CompilerServices;

namespace APBD3;

public class KontenerPlyn : Kontener
{
    public KontenerPlyn(float massOfContainer, float height, float depth, float maxVolumeInKg) : base('L')
    {
        MassOfContainer = massOfContainer;
        Height = height;
        Depth = depth;
        MaxVolumeInKg = maxVolumeInKg;
    }
    
    public override void Empty()
    {
        throw new NotImplementedException();
    }
    
    protected override void Zaladunek(Cargo cargo)
    {
        MassWithCargo += cargo.Mass;
    }
}