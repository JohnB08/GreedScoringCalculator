namespace GreedScoringCalculator.Tests;

using GreedScoringCalculator.App.GreedScoringCalculator;
public class GreedScoringCalculatorTests
{
    [Fact]
    public void TestIfCalculatorCanInitialize()
    {
        var scoreCalculator = new GreedScoringCalculator();

        Assert.NotNull(scoreCalculator);
    }

    [Theory]
    [MemberData(nameof(Data), MemberType = typeof(GreedScoringCalculatorTests))]
    public void TestIfScoreIsCorrect(int[] scores, int expected)
    {
        var calculator = new GreedScoringCalculator();
        var score = calculator.Calculate(scores);

        Assert.Equal(expected, score);
    }

    public static TheoryData<int[], int> Data =>
    new TheoryData<int[], int>{
        {
            new int[]{5, 1, 3, 4, 1 },
            250
        },
        {
            new int[] { 1,1,1,3,1},
            1100
        },
        {
            new int[]{2,4,4,5,4},
            450
        },
        {
            new int[]{ 5,5,3,5,1},
            600
        }
    };
}