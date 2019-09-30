using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipLiteLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }
        public int Spotnumber { get; set; }
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;

    }
}
