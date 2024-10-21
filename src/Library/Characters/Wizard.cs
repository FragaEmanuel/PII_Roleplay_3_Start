using System.Collections.Generic;
namespace Ucu.Poo.RoleplayGame;

public class Wizard : BaseMagicCharacter
{
    public Wizard(string name) :
        base(name)
    {
        this.AddItem(new Staff());
    }
}