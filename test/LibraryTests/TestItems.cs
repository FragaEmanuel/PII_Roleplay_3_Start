using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestItems
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void Item_attack_value() //este test prueba el valor de ataque
    {
        Sword sword = new Sword(); //creo una espada para el test
        int attackValue = sword.AttackValue;
        int resultadoesperado = 20;

        Assert.That(resultadoesperado,Is.EqualTo(attackValue), "El resultado deberia ser 20");
    }
    [Test]
    public void Item_dif_attack_value() //este test prueba un resultado diferente al esperado
    {
        Sword sword = new Sword(); //creo la espada
        int attackValue = sword.AttackValue;
        int resultadoNoEsperado = 15; // Un valor que no debería ser igual al ataque

        Assert.That(attackValue, Is.Not.EqualTo(resultadoNoEsperado), "El valor de ataque no debería ser igual a 15.");
    }

    [Test]
    public void Item_Defense_value()
    {
        Armor armor = new Armor(); //creo una espada para el test
        int defenseValue = armor.DefenseValue;
        int resultadoesperado = 25;

        Assert.That(resultadoesperado,Is.EqualTo((defenseValue)), "El resultado deberia ser 25");
    }
    [Test]
    public void Item_dif_defense_value() //este test prueba un resultado diferente al esperado
    {
        Armor armor = new Armor(); //creo la espada
        int defenseValue = armor.DefenseValue;
        int resultadoNoEsperado = 15; // Un valor que no debería ser igual a la defensa 

        Assert.That(defenseValue, Is.Not.EqualTo(resultadoNoEsperado), "El valor de ataque no debería ser igual a 15.");
    }
}
