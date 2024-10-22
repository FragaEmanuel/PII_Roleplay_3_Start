using Library;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestHeros
{
    public void Setup()
    {
    }
    [Test]
    public void create_BaseCharacter() //Crea la base del personaje hero
    {
        BaseCharacter character = new BaseCharacter("test");
        
        Assert.That("test",Is.EqualTo(character.Name));
        Assert.That(100, Is.EqualTo(character.Health));
        Assert.That(0, Is.EqualTo(character.Vp));
    }

    [Test]
    public void Cure_character()
    {
        BaseCharacter character = new BaseCharacter("test");
        character.ReceiveAttack(50);
        character.Cure();
        Assert.That(100, Is.EqualTo(character.Health));
    }
}