using OpenXml.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Drawing
{
  [Tag("hslColor")]
  [Alias("HslColor")]
  public class HslColor
  {
    [Tag("positiveFixedAngle")]
    PositiveFixedAngleValue Hue{ get; set; }

    [Tag("percentage")]
    PercentageValue Sat{ get; set; }

    [Tag("percentage")]
    PercentageValue Lum{ get; set; }

  }
}
