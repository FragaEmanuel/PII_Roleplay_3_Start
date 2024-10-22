namespace Ucu.Poo.RoleplayGame;

public class EnemyWizard : BaseMagicCharacter, IHeroes
{
    public EnemyWizard(string name) : base(name)
    {
        this.AddItem(new Staff());
    }
}