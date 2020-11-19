using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Model
{
    class Lehrer
    {
        #region Attribute
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Vorname { get; set; }

        public DateTime Einstelldatum { get; set; }
        #endregion

        #region Konstruktor

        public Lehrer(Guid id, String name, String vorname, DateTime einstelldatum)
        {
            Id = id;
            Name = name;
            Vorname = vorname;
            Einstelldatum = einstelldatum;
        }

        #endregion

        #region Methoden
        public String Email()
        {
            return String.Format("{0}.{1}{2}", Vorname.Substring(0,1), Name, "@gso.schule.koeln");
        }

        public String Sende(String nachricht)
        {
            return String.Format("Sende Nachricht:{0} an Email: {1}", nachricht, Email());
        }

        public int Dienstjahre()
        {

            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - Einstelldatum.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (Einstelldatum.Date > today.AddYears(-age)) age--;

            return age;
        }


        #endregion

    }
}
