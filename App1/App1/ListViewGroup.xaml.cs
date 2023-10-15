using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        private ObservableCollection<AlumnosGroup> ListOfStudents { get; set; }

        public ListViewGroup()
        {
            InitializeComponent();

            ListOfStudents = new ObservableCollection<AlumnosGroup>();
            SetupStudents();

            // Asigna los datos a la vista
            listView.ItemsSource = ListOfStudents;

            // Establece si se permite la agrupación en el ListView
            listView.IsGroupingEnabled = true;
        }

        private void SetupStudents()
        {
            var aList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Lucas", Apellido = "Perez" },
                new Alumnos() { Nombre = "Rafael", Apellido = "Reynoso" },
                new Alumnos() { Nombre = "John", Apellido = "Smith" },
                new Alumnos() { Nombre = "Alejo", Apellido = "Davila" },
                new Alumnos() { Nombre = "Gina", Apellido = "Cordova" }
            };
            aList.Heading = "A";

            var bList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Jane", Apellido = "Doe" },
                new Alumnos() { Nombre = "Rafael", Apellido = "Reynoso" },
                new Alumnos() { Nombre = "Lucas", Apellido = "Vazques" }
            };
            bList.Heading = "B";

            var cList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Tony", Apellido = "Kros" },
                new Alumnos() { Nombre = "Rafael", Apellido = "Reynoso" },
                new Alumnos() { Nombre = "Alvaro", Apellido = "Morata" }
            };
            cList.Heading = "C";

            var dList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Lionel", Apellido = "Messi" },
                new Alumnos() { Nombre = "Rafael", Apellido = "Reynoso" },
                new Alumnos() { Nombre = "Ronaldo", Apellido = "Santos" }
            };
            dList.Heading = "D";

            var eList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Xabi", Apellido = "Alonso" },
                new Alumnos() { Nombre = "Rafael", Apellido = "Reynoso" },
                new Alumnos() { Nombre = "Ronald", Apellido = "Araujo" }
            };
            eList.Heading = "E";



            ListOfStudents.Add(aList);
            ListOfStudents.Add(bList);
            ListOfStudents.Add(cList);
            ListOfStudents.Add(dList);
            ListOfStudents.Add(eList);
        }
    }
}
