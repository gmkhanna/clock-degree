using System.Collections.Generic;
using System;

namespace ClockProblem
{
  public class ClockProblem
  {
    private static float _hour;
    private static float _minute;
    private static float _hourAngle;
    private static float _minuteAngle;

    public ClockProblem(float parsedTime)
    {
      if(parsedTime > 1200)
      {
        parsedTime -= 1200;
      }
      else
      {

      }
      float minutes = parsedTime % 100;
      float hour = (parsedTime - minutes) / 100;

      _hour = hour;
      _minute = minutes;

      float hourAngle = hour * 30.0F;
      float minuteAddition = minutes * 0.5F;

      _hourAngle = hourAngle + minuteAddition;
      _minuteAngle = _minute * 6.0F;
    }

    public static float GetHourAngle()
    {
      return _hourAngle;
    }

    public static float GetMinuteAngle()
    {
      return _minuteAngle;
    }

    public static float GetFinalAngle()
    {
      float angleTest1 = Math.Abs(_hourAngle - _minuteAngle);
      float angleTest2 = Math.Abs(_minuteAngle - _hourAngle);

      if(angleTest1 > angleTest2)
      {
        return angleTest2;
      }
      else
      {
        return angleTest1;
      }
    }
  }
}
