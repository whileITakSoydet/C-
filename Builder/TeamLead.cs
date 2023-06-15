using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class TeamLead : IWorker
    {
        public string Works(House house)
        {
            string report = "";
            if (house.Floor is not null)
            {
                report += "фундамент готов\n";
            }
            if (house.Wall.Count > 0)
            {
                report += "стен готово " + house.Wall.Count + "\n";
            }
            if (house.Gate is not null)
            {
                report += "дверь готова\n";
            }
            if (house.Windows.Count > 0)
            {
                report += "окон готово " + house.Windows.Count + "\n";
            }
            if (house.HouseTop is not null)
            {
                report += "крыша готова\n";
            }
            return report;
        }
    }
}
