namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles;

public class Asteroid : BaseObstacle
{
    private const int DefaultDamage = 10;

    public Asteroid()
    {
        PhysDamage = DefaultDamage;
    }
}