using Library;

namespace Ucu.Poo.RoleplayGame;

public class EnemyDwarf : BaseCharacter, IEnemy
{
    public EnemyDwarf(string name) : base(name)
    {
        this.AddItem(new Helmet());
        this.vp = 2;
    }

}