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
                new Alumnos() { Nombre = "Aylin", Apellido = "Tolentino" },
                new Alumnos() { Nombre = "Jerliz", Apellido = "Cruz" },
                new Alumnos() { Nombre = "Johan", Apellido = "Osorio" },
                new Alumnos() { Nombre = "Maylin", Apellido = "Alice" },
                new Alumnos() { Nombre = "Anahi", Apellido = "Damian" }
            };
            aList.Heading = "A";

            var bList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Aylin", Apellido = "Tolentino" },
                new Alumnos() { Nombre = "Lionel", Apellido = "Messi" },
                new Alumnos() { Nombre = "Johan", Apellido = "Osorio" }
            };
            bList.Heading = "B";

            var cList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Tony", Apellido = "Kros" },
                new Alumnos() { Nombre = "Cristiano", Apellido = "Ronaldo" },
                new Alumnos() { Nombre = "Johan", Apellido = "Osorio" }
            };
            cList.Heading = "C";

            var dList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Lionel", Apellido = "Messi" },
                new Alumnos() { Nombre = "Joao", Apellido = "Felix" },
                new Alumnos() { Nombre = "Johan", Apellido = "Osorio" }
            };
            dList.Heading = "D";

            var eList = new AlumnosGroup()
            {
                new Alumnos() { Nombre = "Aylin", Apellido = "Tolentino" },
                new Alumnos() { Nombre = "Cristiano", Apellido = "Ronaldo" },
                new Alumnos() { Nombre = "Johan", Apellido = "Osorio" }
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
