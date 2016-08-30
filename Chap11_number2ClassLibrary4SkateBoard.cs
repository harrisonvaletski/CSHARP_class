using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_number2ClassLibrary4
{
    class Skateboarding : Team
    {
        private string[ ] singlesLineUp;
        private string [ ] doublesTeamMembersNames;
        
        public Skateboarding()
            : base()
        {
        }

        public Skateboarding(string sportType,
                 string Coach, string [ ] singles)
            : base(sportType, Coach)
        {
            singlesLineUp = new string[singles.Length];
            singlesLineUp = singles;
        }

        public Skateboarding(string sportType,
                 string primCoach, string [ ] singles, string[ ] doubles)
            : base(sportType, primCoach)
        {
            singlesLineUp = new string[singles.Length];
            singlesLineUp = singles;
            doublesTeamMembersNames = new string [doubles.Length];
            doublesTeamMembersNames = doubles;
        }

        public string[] SinglesLineUp
        {
            get
            {
                return singlesLineUp;
            }
            set
            {
                singlesLineUp = value;
            }
        }

        public string[] DoublesTeamMembersNames
        {
            get
            {
                return doublesTeamMembersNames;
            }
            set
            {
                doublesTeamMembersNames = value;
            }
        }

        public override string GetWeightRoomAvailability()
        {
            return " MWR 2p-3p  &  " + base.GetWeightRoomAvailability();
        }

        public override string GetSwimPoolAvailability()
        {
            return " MWF 9a-11a  &  " + base.GetSwimPoolAvailability();
        }

        public override string GetSeasonTimeSpan()
        {
            return "Aug - Dec";
        }

      
        public int GetNumberOnTeam( )
        {
            return singlesLineUp.Length;
        }

        public double DetermineTravelMilesMax()
        {
            return 100;
        }

        public string GetSinglesPlayersNames( )
        {
            string names = "";
            foreach(string nm in singlesLineUp)
                names += nm + "\n";
            return names;
        }

        public override string ToString()
        {
            return base.ToString() +
                "Players: " + GetSinglesPlayersNames();
        }
    }
}
