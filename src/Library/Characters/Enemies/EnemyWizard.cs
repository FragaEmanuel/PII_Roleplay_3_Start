namespace Ucu.Poo.RoleplayGame;

public class EnemyWizard : BaseMagicCharacter, IEnemy, IMagicCharacter
{
    public EnemyWizard(string name) : base(name)
    {
        this.AddItem(new Staff());
        this.vp = 3;
    }
}