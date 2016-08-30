using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_number1ClassLibrary6
{
    public abstract class Team
    {
        private string sport;
        private string Coach;
        private string Doctor;
        private string practiceLocation1;

        public Team()
        {
        }

        public Team(string type, string teamCoach)
        {
            sport = type;
            Coach = teamCoach;
        }

        public Team(string type, string headCoach,
            string doctor, string site1)
        {
            sport = type;
            Coach = headCoach;
            Doctor = doctor;
            practiceLocation1 = site1;
        }

        public virtual string GetSeasonTimeSpan()
        {
            return " August - May";
        }

        public virtual string GetWeightRoomAvailability()
        {
            return " MTWRF 10a-12p";
        }

        public virtual string GetLibraryAvailability()
        {
            return " MTWRF 4p-6p";
        }

        public string Sport
        {
            get
            {
                return sport;
            }
            set
            {
                sport = value;
            }
        }

        public string coach
        {
            get
            {
                return Coach;
            }
            set
            {
                Coach = value;
            }
        }

        public string doctor
        {
            get
            {
                return Doctor;
            }
            set
            {
                Doctor = value;
            }
        }

        public string PracticeLocation1
        {
            get
            {
                return practiceLocation1;
            }
            set
            {
                practiceLocation1 = value;
            }
        }

        public override string ToString()
        {
            return  "Sport: " +  sport +
                    "Coach: " + Coach;
        }
    }

}
