namespace Ucu.Poo.RoleplayGame;

public class EnemyArcher: BaseEnemy
{
    public EnemyArcher(string name, int vp) : base(name, vp)
    {
        this.AddItem(new Bow());
    }

}