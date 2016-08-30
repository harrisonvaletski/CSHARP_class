using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_number2ClassLibrary4
{
    class Lacrosse : Team
    {
        private string boatHouseHours;
        private string headCoxswain;

        public Lacrosse()
            : base()
        {
        }

        public Lacrosse(string sportType, string primCoach, string boatHsHrs)
            : base(sportType, primCoach)
        {
            boatHouseHours = boatHsHrs;
        }

        public Lacrosse(string sportType, string primCoach, string boatHsHrs,
                        string headRower)
            : base(sportType, primCoach)
        {
            boatHouseHours = boatHsHrs;
            headCoxswain = headRower;
        }


        public override string GetWeightRoomAvailability()
        {
            return " MTFS 6a-7a  &  " + base.GetWeightRoomAvailability();
        }

        public override string GetSwimPoolAvailability()
        {
            return " TRS 9a-11a  &  " + base.GetSwimPoolAvailability();
        }

        public override string GetSeasonTimeSpan()
        {
            return "Nov - April";
        }

        public string BoatHouseHours
        {
            get
            {
                return boatHouseHours;
            }
            set
            {
                boatHouseHours = value;
            }
        }

        public string HeadCoxswain
        {
            get
            {
                return headCoxswain;
            }
            set
            {
                headCoxswain = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nHeadCoxswain: " + headCoxswain;

        }
    }
}

        public override string ToString()
        {
            return  "Sport: " +  sport +
                    "Coach: " + Coach;
        }
    }

}
