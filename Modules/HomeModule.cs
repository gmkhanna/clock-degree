using Nancy;
using System;
using System.Collections.Generic;

namespace ClockProblem
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {

        return View["index.cshtml"];
      };

      Post["/submit"] = _ => {
      string timeResult = Request.Form["time"];
      string timeMinusColon = timeResult.Remove(2,1);
      float parsedTime = float.Parse(timeMinusColon);
      Console.WriteLine(parsedTime);

      ClockProblem newClock = new ClockProblem(parsedTime);

      Console.WriteLine("Minute Angle:" + ClockProblem.GetMinuteAngle());
      Console.WriteLine("Hour angle: " +  ClockProblem.GetHourAngle());
      return View["output.cshtml", ClockProblem.GetFinalAngle()];
      };
    }
  }
}
