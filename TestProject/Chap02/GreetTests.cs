using TargetProject.Chap02;

namespace TestProject.Chap02;
/// <summary>
/// Calculatorクラスに実装されたメソッドの単体テストドライバ
/// </summary>
[TestClass]
public class GreetTests
{
    [TestMethod("テストケース1:朝の時間帯(代表値)ではGood Morningを返す")]
    public void Add_ShouldReturnSum_WhenBothHaveValues()
    {
        // Arrange(準備)
        var greet = new GreetingService();
        int hour = 8;
        // Act(実行)
        var result = greet.Greet(hour);
        // Assert(確認)
        Assert.AreEqual("Good Morning", result);
    }
}
