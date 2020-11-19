using SmartSchool.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SmartSchool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Schueler hans = new Schueler(Guid.NewGuid(), "Mueller", "Hans", new DateTime(2022, 6, 15));
        Schueler peter = new Schueler(Guid.NewGuid(), "Mueller", "Peter", new DateTime(2023, 8, 15));

        Lehrer krone = new Lehrer(Guid.NewGuid(), "Krone", "Stefan", new DateTime(2015, 7, 20));
        Lehrer vosshall = new Lehrer(Guid.NewGuid(), "Vosshall", "Ingrid", new DateTime(1999, 4, 17));

        Administrator oehler = new Administrator(Guid.NewGuid(), "Oehler", "Steffen", new DateTime(1985, 3, 7));
        Administrator wehrle = new Administrator(Guid.NewGuid(), "Wehrle", "Boris", new DateTime(1970, 9, 25));

        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void BtnStartSchueler_Click(object sender, RoutedEventArgs e)
        {
            txtNameSchueler.Text = hans.Name;
            txtVornameSchueler.Text = hans.Vorname;
            txtEmailSchueler.Text = hans.Email();
            txtAbschlussSchueler.Text = hans.TageBisAbschluss().ToString();
        }

        private void BtnStartLehrer_Click(object sender, RoutedEventArgs e)
        {
            txtNameLehrer.Text = krone.Name;
            txtVornameLehrer.Text = krone.Vorname;
            txtEmailLehrer.Text = krone.Email();
            txtDienstjahreLehrer.Text = krone.Dienstjahre().ToString();
        }

        private void BtnStartAdmin_Click(object sender, RoutedEventArgs e)
        {
            txtNameAdmin.Text = oehler.Name;
            txtVornameAdmin.Text = oehler.Vorname;
            txtEmailAdmin.Text = oehler.Email();
            txtAlterAdmin.Text = oehler.Age().ToString();
        }
    }
}
