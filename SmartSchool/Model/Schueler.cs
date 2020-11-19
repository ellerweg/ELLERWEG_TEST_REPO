using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Model
{
    class Schueler
    {
        #region Attribute
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Vorname { get; set; }

        public DateTime VoraussichtlicherAbschluss { get; set; }
        #endregion

        #region Konstruktor

        public Schueler(Guid id, String name, String vorname, DateTime voraussichtlicherAbschluss)
        {
            Id = id;
            Name = name;
            Vorname = vorname;
            VoraussichtlicherAbschluss = voraussichtlicherAbschluss;
        }

        #endregion

        #region Methoden
        public String Email()
        {
            return String.Format("{0}.{1}{2}", Vorname, Name.Substring(0, 1), "@gso.schule.koeln");
        }

        public String Sende(String nachricht)
        {
            return String.Format("Sende Nachricht:{0} an Email: {1}", nachricht, Email());
        }

        public int TageBisAbschluss()
        {

            // Save today's date.
            var timeSpan = VoraussichtlicherAbschluss - DateTime.Today ;
            return Convert.ToInt32(timeSpan.TotalDays);
        }


        #endregion
    }
}
