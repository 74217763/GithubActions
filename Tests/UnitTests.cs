
namespace GithubActionsLab;

[TestClass]
public class UnitTests
{
    [TestMethod]
    public void Add_Valid_Eloume()
    {
        Assert.AreEqual(3.0, Program.Add("1", "2"));
        Assert.AreEqual(5.0, Program.Add("3", "2"));
        Assert.AreEqual(12.0, Program.Add("5", "7"));
    }

    [TestMethod]
    public void Add_Invalid_Eloume()
    {
        Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
    }

    [TestMethod]
    public void Add_Null_Eloume()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null!, null!));
    }

    [TestMethod]
    public void Subtract_Valid_Eloume()
    {
        Assert.AreEqual(-1.0, Program.Subtract("1", "2"));
        Assert.AreEqual(1.0, Program.Subtract("3", "2"));
        Assert.AreEqual(-2.0, Program.Subtract("5", "7"));
    }

    [TestMethod]
    public void Subtract_Invalid_Eloume()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Eloume()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null!, null!));
    }

    [TestMethod]
    public void Multiply_Valid_Eloume()
    {
        Assert.AreEqual(2.0, Program.Multiply("1", "2"));
        Assert.AreEqual(6.0, Program.Multiply("3", "2"));
        Assert.AreEqual(35.0, Program.Multiply("5", "7"));
    }

    [TestMethod]
    public void Multiply_Invalid_Eloume()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Multiply_Null_Eloume()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null!, null!));
    }

    [TestMethod]
    public void Divide_Valid_Eloume()
    {
        Assert.AreEqual(0.5, Program.Divide("1", "2"));
        Assert.AreEqual(1.5, Program.Divide("3", "2"));
        Assert.AreEqual(5.0, Program.Divide("35", "7"));
    }

    [TestMethod]
    public void Divide_Invalid_Eloume()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Divide_Null_Eloume()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null!, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null!, null!));
    }

    [TestMethod]
    public void Power_Valid_Eloume()
    {
        Assert.AreEqual(8.0, Program.Power("2", "3"));
        Assert.AreEqual(25.0, Program.Power("5", "2"));
        Assert.AreEqual(1.0, Program.Power("7", "0"));
    }

    [TestMethod]
    public void Power_Invalid_Eloume()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

    [TestMethod]
    public void Power_Null_Eloume()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null!));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null!, "2"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null!, null!));
    }
}
