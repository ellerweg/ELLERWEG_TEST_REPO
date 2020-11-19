using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Model
{
    class Administrator
    {
        #region Attribute
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String  Vorname { get; set; }

        public DateTime Geburtsdatum { get; set; }
        #endregion

        #region Konstruktor

        public Administrator(Guid id, String name, String vorname, DateTime geburtsdatum)
        {
            Id = id;
            Name = name;
            Vorname = vorname;
            Geburtsdatum = geburtsdatum;
        }

        #endregion

        #region Methoden
        public String Email()
        {
            return String.Format("{0}.{1}{2}", Vorname, Name, "@gso.schule.koeln");
        }

        public String Sende(String nachricht)
        {
            return String.Format("Sende Nachricht:{0} an Email: {1}", nachricht, Email());
        }

        public int Age()
        {

            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - Geburtsdatum.Year;

            // Go back to the year in which the person was born in case of a leap year
            if (Geburtsdatum.Date > today.AddYears(-age)) age--;

            return age;
        }


        #endregion


    }
}
