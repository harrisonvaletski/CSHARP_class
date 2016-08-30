using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_number3ClassLibrary5
{
    public class Lacrosse : Team
    {
        private string FeildHours;
        private string Captain;

        public Lacrosse()
            : base()
        {
        }

        public Lacrosse(string sportType, string primCoach, string Feildhrs)
            : base(sportType, primCoach)
        {
            FeildHours = Feildhrs;
        }

        public Lacrosse(string sportType, string primCoach, string Feildhrs,
                        string Cpn)
            : base(sportType, primCoach)
        {
            FeildHours = Feildhrs;
            Captain = Cpn;
        }


        public override string GetWeightRoomAvailability()
        {
            return " MTFS 6a-7a  &  " + base.GetWeightRoomAvailability();
        }

        public override string GetLibraryAvailability()
        {
            return " TRS 9a-11a  &  " + base.GetLibraryAvailability();
        }

        public override string GetSeasonTimeSpan()
        {
            return "Nov - April";
        }

        public string Feildhours
        {
            get
            {
                return FeildHours;
            }
            set
            {
                FeildHours = value;
            }
        }

        public string TeamCaptain
        {
            get
            {
                return Captain;
            }
            set
            {
                Captain = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() +
                "\n\nTeamCaptain: " + Captain;

        }
    }
}
