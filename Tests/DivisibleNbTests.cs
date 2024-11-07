using Katas;

namespace Tests;

[TestFixture]
public class DivisibleNbTests {
    
    [Test, Order(1)]
    public void Test1() {
        Assert.That(DivisibleNb.IsDivisible(12, 4, 3), Is.EqualTo(true), "n = 12, x = 3, y = 4");
    }
    
    [Test, Order(2)]
    public void Test2() {
        Assert.That(DivisibleNb.IsDivisible(3, 3, 4), Is.EqualTo(false), "n = 3, x = 3, y = 4");
    }
    [Test, Order(3)]  
    public void Test3() {
        Assert.That(DivisibleNb.IsDivisible(8, 3, 4), Is.EqualTo(false), "n = 8, x = 3, y = 4");
    }
}
  