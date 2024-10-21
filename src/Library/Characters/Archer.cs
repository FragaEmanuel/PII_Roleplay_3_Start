using System.Collections.Generic;
using Library;

namespace Ucu.Poo.RoleplayGame;

public class Archer: BaseCharacter
{
    public Archer(string nombre)
        : base(nombre)
    {
        this.AddItem(new Bow());
        this.AddItem(new Helmet());
    }
}
