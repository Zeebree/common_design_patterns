using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Domain;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Domain.Composite("Company");

            Component ceo = new Leaf("CEO");
            root.Add(ceo);
            Component team1 = new Domain.Composite("Team 1");
            root.Add(team1);
            Component team2 = new Domain.Composite("Team 2");
            root.Add(team2);

            Component lead1 = new Leaf("Leader 1");
            team1.Add(ceo);
            Component dev1 = new Leaf("Developer 1");
            team1.Add(dev1);
            Component dev2 = new Leaf("Developer 2");
            team1.Add(dev2);

            Component lead2 = new Leaf("Leader 2");
            team2.Add(ceo);
            Component steam1 = new Domain.Composite("SubTeam 1");
            team2.Add(steam1);
            Component steam2 = new Domain.Composite("SubTeam 2");
            team2.Add(steam2);

            root.Display(0, 4);
        }
    }
}
