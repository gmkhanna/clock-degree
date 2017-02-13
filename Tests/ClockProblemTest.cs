using System.Collections.Generic;
using Xunit;

namespace ClockProblem
{
  public class ClockProblemTest
  {

    [Fact]
    public void Test_Angle()
    {
      float hourHand = 3.0F;
      float minuteHand = 25.0F;
      ClockProblem.CalculateAngles(hourHand, minuteHand);

      float calculatedAngle = ClockProblem.GetHourAngle();

      Assert.Equal(102.5F, calculatedAngle);
    }
  }
}
