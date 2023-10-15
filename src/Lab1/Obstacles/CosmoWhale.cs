namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class CosmoWhale : BaseObstacle
{
    private const int DefaultDamage = 400;

    public CosmoWhale()
    {
        PhysDamage = DefaultDamage;
    }
}