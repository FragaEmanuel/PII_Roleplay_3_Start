using System;
using Library;

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
        EnemyArcher Enemy1 = new EnemyArcher("Enemy1");
        EnemyDwarf Enemy2 = new EnemyDwarf("Enemy2");
        EnemyWizard wizard_enemy = new EnemyWizard("enemy_wizard");
        wizard_enemy.AddItem(book);

        Encounters encounters1 = new Encounters();
        encounters1.AddParticipant(gandalf);
        encounters1.AddParticipant(Enemy2);
     
        encounters1.DoEncounter();
        
      
    }
}
