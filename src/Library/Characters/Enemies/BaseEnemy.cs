using Library;

namespace Ucu.Poo.RoleplayGame;

public class BaseEnemy: BaseCharacter, IEnemy
{
    //protected static string name1;            //atributo nombre
    public BaseEnemy(string name1, int vp): base(name1)
    {
        this.Name = name1;
        this.Vp = vp;
    }
    


    public void defeated_by_Hero(BaseCharacter Hero) //metodo para ser derrotade por un hero
    {
        Hero.Vp += this.Vp;
        
    }
}
    