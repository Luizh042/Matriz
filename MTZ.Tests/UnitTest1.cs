namespace MTZ.Tests;

public class Tests
{
    Matriz _matriz;
    [SetUp]
    public void Setup()
    {
        _matriz = new Matriz();
    }

    [Test]
    public void Test1()
    {
        int[,] etapa1 = _matriz.ex1();
        Assert.AreEqual(etapa1[0, 0],1);
        Assert.Pass();
    }
}