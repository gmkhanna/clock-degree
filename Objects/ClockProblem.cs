using System.Collections.Generic;

namespace ClockProblem
{
  public class ClockProblem
  {
    public static float CalculateMinutesAngle(float minutes)
    {
      return minutes * 6.0F;
    }

    public static float CalculateHourAngle(float hours, float minutes)
    {
      float hourAngle = hours * 30.0F;
      float minuteAddition = minutes * 0.5F;

      return hourAngle + minuteAddition;
    }
  }
}
