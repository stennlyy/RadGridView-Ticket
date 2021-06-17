using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Controls;

namespace RadGridViewTicket
{
    //ViewModel Class for presenting a static entries in the RadGridView
    public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<FootballTeam> footballTeams;

        public ObservableCollection<FootballTeam> FootballTeams
        {
            get
            {
                if(this.footballTeams == null)
                {
                    this.footballTeams = this.CreateTeams();
                }

                return this.footballTeams;
            }
        }

        private ObservableCollection<FootballTeam> CreateTeams()
        {
            ObservableCollection<FootballTeam> footballTeams = new ObservableCollection<FootballTeam>();

            FootballTeam footballTeam;

            footballTeam = new FootballTeam("Liverpool", new DateTime(1892, 1, 1), 45362);

            footballTeams.Add(footballTeam);

            footballTeam = new FootballTeam("Manchester Utd.", new DateTime(1878, 1, 1), 76212);

            footballTeams.Add(footballTeam);

            footballTeam = new FootballTeam("Chelsea", new DateTime(1905, 1, 1), 42055);

            footballTeams.Add(footballTeam);

            return footballTeams;
        }
    }
}
