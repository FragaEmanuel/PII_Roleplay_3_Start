namespace Ucu.Poo.RoleplayGame;

public class EnemyDwarf : BaseEnemy
{
    public EnemyDwarf(string name, int vp) : base(name, vp)
    {
        this.AddItem(new Helmet());
    }

}