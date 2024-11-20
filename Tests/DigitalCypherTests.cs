namespace Tests;
using NUnit.Framework;
using System;
using Katas;

[TestFixture]
public class DigitalCypherTests
{
    [Test]
    public void BasicTest()
    {
        Assert.That(DigitalCypher.Encode("scout", 1939), Is.EqualTo(new int[] { 20, 12, 18, 30, 21 }));
        Assert.That(DigitalCypher.Encode("masterpiece", 1939), Is.EqualTo(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }));
    }

    [Test]
    public void TestConvertToNumbers()
    {
        Assert.That(DigitalCypher.ConvertToNumbers("a"), Is.EqualTo(new int[]{1}));
        Assert.That(DigitalCypher.ConvertToNumbers(""), Is.EqualTo(new int[]{}));
        Assert.That(DigitalCypher.ConvertToNumbers("scout"), Is.EqualTo(new int[]{19, 3, 15, 21, 20}));
    }

    [Test]
    public void TestGetDigits()
    {
        Assert.That(DigitalCypher.GetDigits(0), Is.EqualTo(new int[]{0}));
        Assert.That(DigitalCypher.GetDigits(1), Is.EqualTo(new int[]{1}));
        Assert.That(DigitalCypher.GetDigits(123), Is.EqualTo(new int[]{1, 2, 3}));
    }
}
