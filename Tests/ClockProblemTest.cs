using System.Collections.Generic;
using Xunit;

namespace ClockProblem
{
  public class ClockProblemTest
  {
    [Fact]
    public void Test_MinuteHand_Angle()
    {
      float minuteHand = 55.0F;
      float returnedInt = ClockProblem.CalculateMinutesAngle(minuteHand);

      Assert.Equal(330.0F, returnedInt);
    }

    [Fact]
    public void Test_HourHand_Angle()
    {
      float hourHand = 3.0F;
      float minuteHand = 25.0F;

      float returnedInt = ClockProblem.CalculateHourAngle(hourHand, minuteHand);

      Assert.Equal(102.5F, returnedInt);
    }
  }
}
