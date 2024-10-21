namespace Ucu.Poo.RoleplayGame;

public interface ICharacter
{
    string Name { get; set; }

    int Health { get; }

    int AttackValue { get; }

    int DefenseValue { get; }
    
    int Vp { get; set; }

    void AddItem(IItem item);

    void RemoveItem(IItem item);
    
    void Cure();

    void Attack(ICharacter target);

    void ReceiveAttack(int power);

    
}
