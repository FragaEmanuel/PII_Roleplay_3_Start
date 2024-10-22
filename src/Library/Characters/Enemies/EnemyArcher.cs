using Library;

namespace Ucu.Poo.RoleplayGame;

public class EnemyArcher: BaseCharacter, IEnemy
{
    public EnemyArcher(string name) : base(name)
    {
        this.AddItem(new Bow());
    }

}