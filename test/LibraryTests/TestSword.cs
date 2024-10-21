using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestSword
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void Sword_attack_value()
    {
        Sword sword = new Sword(); //creo la espada
        int attackValue = sword.AttackValue;
        int resultadoesperado = 20;

        Assert.That(resultadoesperado,Is.EqualTo(attackValue), "El resultado deberia ser 20");
    }
    [Test]
    public void Sword_dif_attack_value()
    {
        Sword sword = new Sword(); //creo la espada
        int attackValue = sword.AttackValue;
        int resultadoNoEsperado = 15; // Un valor que no debería ser igual al ataque

        Assert.That(attackValue, Is.Not.EqualTo(resultadoNoEsperado), "El valor de ataque no debería ser igual a 15.");

    }
    
}
/* [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    } */