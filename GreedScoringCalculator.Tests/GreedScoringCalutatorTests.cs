namespace GreedScoringCalculator.Tests;

public class GreedScoringCalculatorTests
{
    [Fact]
    public void TestIfCalculatorCanInitialize()
    {
        var scoreCalculator = new GreedScoringCalculator();

        Assert.NotNull(scoreCalculator);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void TestIfScoreIsCorrect(int[] scores, int expected)
    {
        var calculator = new GreedScoringCalculator();
        var scores = calculator.Calculate(scores);

        Assert.Equal(expected, scores);
    }

    public static TheoryData<object[]> Data =>
    [
        [
            new int[]{5, 1, 3, 4, 1 },
            250
        ],
        [
            new int[] { 1,1,1,3,1},
            1100
        ],
        [
            new int[]{2,4,4,5,4},
            450
        ],
        [
            new int[]{ 5,5,3,5,1},
            600
        ]
    ];
}