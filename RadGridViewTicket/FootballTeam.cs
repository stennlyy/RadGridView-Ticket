using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadGridViewTicket
{
    //Simple Class and Properties
    public class FootballTeam
    {
        public FootballTeam(string name, DateTime estYear, int stadiumCapacity)
        {
            this.Name = name;
            this.EstYear = estYear;
            this.StadiumCapacity = stadiumCapacity;
        }

        public string Name { get; set; }

        public DateTime EstYear { get; set; }

        public int StadiumCapacity { get; set; }
    }
}
