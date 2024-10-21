using Ucu.Poo.RoleplayGame;

namespace Library;

public class BaseCharacter : ICharacter
{
    private string name;            //atributo nombre
    private int health;
    private int maxhealth;
    protected List<IItem> items = new List<IItem>();
    
    public BaseCharacter(string name)          //metodo constructor
    {
        this.Name = name;                   //toma el string para el nombre
        this.maxhealth = 100;         //toma el entero dado para que sea la vida maxima
        this.Health = maxhealth;            //le da el mismo valor a la vida actual
    }
    public string Name { get; set; }           //metodo para poner o saber nombre

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }
    
    public virtual void AddItem(IItem item)        //metodo añadir item
    {
        if (item != null)
        {
            this.items.Add(item);
        }
        else
        {
            Console.WriteLine("Ese item no existe");
        }
    }

    public virtual void RemoveItem(IItem item)             //metodo quitar item
    {
        if (item != null)
        {
            this.items.Remove(item);
        }
        else
        {
            Console.WriteLine("Ese item no existe");
        }
    }
    
    public virtual int AttackValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IAttackItem)
                {
                    value += (item as IAttackItem).AttackValue;
                }
            }
            return value;
        }
    }
    public virtual int DefenseValue
    {
        get
        {
            int value = 0;
            foreach (IItem item in this.items)
            {
                if (item is IDefenseItem)
                {
                    value += (item as IDefenseItem).DefenseValue;
                }
            }
            return value;
        }
    }

    
    public void Attack(ICharacter target) //metodo para atacar
    {
        int damage = this.AttackValue; //se calcula el daño total
        Console.WriteLine($"{this.Name} ataca a {target.Name} y causa {damage} de daño."); //se imprime un mensaje
        target.ReceiveAttack(damage);   //se llama al metodo ReceiveDamage de la clase Chara
    }
    public void ReceiveAttack(int damage) //metodo para recibir daño
    {
        this.Health -= damage - this.DefenseValue; //se resta el daño a la vida
        if (this.Health < 0) this.Health = 0; //si la vida es menor a 0, se asigna 0
        Console.WriteLine($"{this.name} recibe {damage} de daño. Vida restante: {this.Health}"); //se imprime un mensaje
    }
    public void Cure() //metodo para curar
    {
        this.health = this.maxhealth; //se asigna la vida maxima a la vida
        Console.WriteLine($"{this.name} ha sido curado. Vida restaurada a: {this.health}"); //se imprime un mensaje
    }
}