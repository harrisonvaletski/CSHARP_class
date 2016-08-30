using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_number3ClassLibrary5
{
    public class Skateboarding : Team
    {
        private string[ ] singlesLineUp;
        private string [ ] doublesTeamMembersNames;
        
        public Skateboarding()
            : base()
        {
        }

        public Skateboarding(string sportType,
                 string primCoach, string [ ] singles)
            : base(sportType, primCoach)
        {
            singlesLineUp = new string[singles.Length];
            for (int i = 0; i < singles.Length; i++)
            {
                singlesLineUp[i] = singles[i];
            }
        }

        public Skateboarding(string sportType,
                 string primCoach, string [ ] singles, string[ ] doubles)
            : base(sportType, primCoach)
        {
            singlesLineUp = new string[singles.Length];
            for (int i = 0; i < singles.Length; i++)
            {
                singlesLineUp[i] = singles[i];
            }
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

        public int ReturnNumberOfPlayers()
        {
            return singlesLineUp.Length;
        }

        public override string GetWeightRoomAvailability()
        {
            return " MWR 2p-3p  &  " + base.GetWeightRoomAvailability();
        }

        public override string GetLibraryAvailability()
        {
            return " MWF 9a-11a  &  " + base.GetLibraryAvailability();
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
            return base.ToString() + "\n\n" +
                "\n\nPlayers: " + GetSinglesPlayersNames();
        }
    }
}
