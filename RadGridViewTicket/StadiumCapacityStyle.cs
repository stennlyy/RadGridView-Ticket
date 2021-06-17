using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RadGridViewTicket
{
    //Custom Style logic to be applied to the StadiumCapacity property of FootballTeam class
    public class StadiumCapacityStyle : StyleSelector
    {
        public Style BigStadiumStyle { get; set; }
        public Style SmallStadiumStyle { get; set; }

        public override Style SelectStyle(object item, DependencyObject container)
        {
            if(item is FootballTeam)
            {
                FootballTeam footballTeam = item as FootballTeam;

                if(footballTeam.StadiumCapacity > 50000)
                {
                    return this.BigStadiumStyle;
                }
                else
                {
                    return this.SmallStadiumStyle;
                }
            }

            return null;
        }
    }
}
