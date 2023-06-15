using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Team
    {
        public List<Worker> Worker;
        public Team()
        {
            Worker = new List<Worker>();
        }
        public void AddWorker(Worker worker)
        {
            Worker.Add(worker);
        }
        public string Build(House house)
        {
            if (Worker.Count < 3)
            {
                return "Работников слишком мало";
            }
            if (house.Floor is null)
            {
                house.Floor = new Basement();
                return "Мы построил фундамент";
            }
            if (house.Wall.Count < 4)
            {
                house.Wall.Add(new Walls());
                return "Мы построил стену";
            }
            if (house.Gate is null)
            {
                house.Gate = new Door();
                return "Мы построил дверь";
            }
            if (house.Windows.Count < 4)
            {
                house.Windows.Add(new Window());
                return "Мы построил окно";
            }
            if (house.HouseTop is null)
            {
                house.HouseTop = new Roof();
                return "Мы построил крышу";
            }
            return "Начальника все гатова\nПирив!!!";
        }
    }
}
