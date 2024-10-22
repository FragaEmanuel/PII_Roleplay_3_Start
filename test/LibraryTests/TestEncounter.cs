using Library;
using NUnit.Framework;
using Ucu.Poo.RoleplayGame;

namespace LibraryTests;

public class TestEncounter
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_vp() //este test prueba el valor de ataque
    {
        Knight knight1 = new Knight("knigt1");
        EnemyArcher Enemy1 = new EnemyArcher("Enemy1");

        Encounters encounter1 = new Encounters();

        encounter1.AddParticipant(knight1);
        encounter1.AddParticipant(Enemy1);

        int resultadoesperado = 2;

        Assert.That(resultadoesperado, Is.EqualTo(knight1.Vp), "El resultado deberia ser 2");
    }

    [Test]
    public void AddParticipant() //este test prueba un resultado diferente al esperado
    {
        Knight knight1 = new Knight("knigt1");
        EnemyArcher Enemy1 = new EnemyArcher("Enemy1");

        Encounters encounter1 = new Encounters();

        encounter1.AddParticipant(knight1);
        encounter1.AddParticipant(Enemy1);

        List<IHeroes> resultadoNoEsperado = new List<IHeroes>();


        Assert.That(encounter1.HeroesList, Is.Not.EqualTo(resultadoNoEsperado),
            "La lista no debe de estar vacia");
    }
}
