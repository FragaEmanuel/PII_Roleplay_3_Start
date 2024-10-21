using System.Collections.Generic;
using Library;

namespace Ucu.Poo.RoleplayGame;

public class Dwarf : BaseCharacter, IHeroes
{
    public Dwarf(string nombre)
        : base(nombre)
    {
        this.AddItem(new Axe());
        this.AddItem(new Helmet());
    }
}