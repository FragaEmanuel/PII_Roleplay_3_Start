using System.Collections.Generic;
using Library;

namespace Ucu.Poo.RoleplayGame;

public class Knight: BaseCharacter, IHeroes
{

    public Knight(string nombre)
        : base(nombre)
    {
        this.AddItem(new Sword());
        this.AddItem(new Armor());
        this.AddItem(new Shield());
    }
}
