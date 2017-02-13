using System.Collections.Generic;

namespace ClockProblem
{
  public class ClockProblem
  {
    private static float _hourAngle;
    private static float _minuteAngle;

    public static void CalculateAngles(float hours, float minutes)
    {
      float hourAngle = hours * 30.0F;
      float minuteAddition = minutes * 0.5F;

      _hourAngle = hourAngle + minuteAddition;
      _minuteAngle = minutes * 6.0F;
    }

    public static float GetHourAngle()
    {
      return _hourAngle;
    }

    public static float GetMinuteAngle()
    {
      return _minuteAngle;
    }



  }
}
