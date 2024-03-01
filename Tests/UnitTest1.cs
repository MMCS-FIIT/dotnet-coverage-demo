namespace Tests;

using static App.Program;

public class Tests
{
    [Test]
    public static void TestAdd()
    {
        Assert.That(Add(1, 2), Is.EqualTo(3));
    }
}
