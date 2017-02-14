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
      Dictionary<string, float> model = new Dictionary<string, float>{};
      ClockProblem newClock = new ClockProblem(parsedTime);

      model.Add("hourAngle", ClockProblem.GetHourAngle());
      model.Add("minuteAngle", ClockProblem.GetMinuteAngle());
      model.Add("finalAngle", ClockProblem.GetFinalAngle());

      return View["output.cshtml", model];
      };
    }
  }
}
