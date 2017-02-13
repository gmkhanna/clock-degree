using System.Collections.Generic;
using Xunit;
using System;

namespace ClockProblem
{
  public class ClockProblemTest
  {

    [Fact]
    public void Test_Angle()
    {
      float hourHand = 325F;

      ClockProblem newClock = new ClockProblem(hourHand);

      float calculatedAngle = ClockProblem.GetFinalAngle();

      Assert.Equal(47.5, calculatedAngle);
    }
  }
}
