using Ucu.Poo.RoleplayGame;

namespace Library;

public class Encounters
{
    public Encounters()
    {
    }

    private List<IHeroes> Heroes;
    private List<IEnemy> Enemies;
    
    public void AddParticipant(IEnemy chara)
    {
        Enemies.Add(chara);
    }
    
    public void AddParticipant(IHeroes chara)
    {
        Heroes.Add(chara);
    }

    public void DoEncounter()
    {
        if (Heroes.Count < 1 || Enemies.Count < 1)
        {
            Console.WriteLine("Debe haber al menos un heroe y un enemigo para que el encuentro se valido");
            return;
        }

        while (Heroes.Count > 0 && Enemies.Count > 0)
        {
            //Fase 1 -- Turno Enemigos
            for (int i = 0; i < Enemies.Count; i++)
            {
                int heroIndex = i % Heroes.Count;
                var enemy = Enemies[i];
                var hero = Heroes[heroIndex];

                enemy.Attack(hero);

                // Verificar si el héroe ha sido derrotado
                if (!(hero.Health > 0))
                {
                    Heroes.RemoveAt(heroIndex);
                    // Ajustar el índice para el siguiente enemigo
                    heroIndex--;
                }

                // Terminar si no quedan héroes
                if (Heroes.Count == 0)
                {
                    EndEncounter();
                    return;
                }
            }

            //Fase 2 -- Turno Heroes

            foreach (var hero in Heroes)
            {
                foreach (var enemy in Enemies)
                {
                    if (enemy.Health > 0)
                    {
                        hero.Attack(enemy);
                        // Verificar si el enemigo ha sido derrotado
                        if (!(enemy.Health > 0))
                        {
                            hero.Vp += enemy.Vp;
                        }
                    }
                }
            }


            // Eliminar enemigos derrotados
            Enemies.RemoveAll(e => !(e.Health > 0));

            // Terminar si no quedan enemigos
            if (Enemies.Count == 0)
            {
                EndEncounter();
                return;
            }
        }
    }

    public void EndEncounter()
    {
        if (Heroes.Count == 0)
        {
            Console.WriteLine("No queda ningun heroe en pie, los enemigos han ganado");
        }
        else if (Enemies.Count == 0)
        {
            Console.WriteLine("Los heroes han ganado");
            foreach (var heroe in Heroes)
            {
                if (heroe.Vp > 5)
                {
                    heroe.Cure();
                    heroe.Vp -= 5;
                }
            }
        }
    }
}