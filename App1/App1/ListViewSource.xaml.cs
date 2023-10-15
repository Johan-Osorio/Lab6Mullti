using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();

            EmployeeView.ItemsSource= employees;
            employees.Add(new Employee { DisplayName = "Johan Osorio"});
            employees.Add(new Employee { DisplayName = "Lionel Messi" });
            employees.Add(new Employee { DisplayName = "Crisitano Ronaldo" });
            employees.Add(new Employee { DisplayName = "Joao Felix" });
            employees.Add(new Employee { DisplayName = "Robert Lewandowsky" });
            employees.Add(new Employee { DisplayName = "Marc Andre Ter Stegen" });

        }
    }
}