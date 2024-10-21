using System;

namespace Ucu.Poo.RoleplayGame.Program;

class Program
{
    static void Main(string[] args)
    {
        SpellsBook book = new SpellsBook();
        book.AddSpell(new SpellOne());
        book.AddSpell(new SpellOne());

        //Crear Heroes
        Wizard gandalf = new Wizard("Gandalf");
        gandalf.AddItem(book);
        Dwarf gimli = new Dwarf("Gimli");
        Knight knight1 = new Knight("knigt1");

        //crear enemigos
        EnemyArcher Enemy1 = new EnemyArcher("Enemy1", 10);
        //Console.WriteLine(Enemy1.Name);

        /*Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

        gimli.ReceiveAttack(gandalf.AttackValue);

        Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

        gimli.Cure();

        Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}"); */
    }
}
