using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;

namespace PropertyGridEditor_Attribute {
    public class ViewModel : ViewModelBase {
        public Department Department { get; set; }
        public ViewModel() {
            Department = new Department {
                Name = "Marketing",
                Location = new Location { Country = "USA", City = "Seattle", Adress = "11th Ave. N.E.", ZIP = 4726 },
                Employees = new ObservableCollection<Employee>() {
                    new Employee { FirstName = "Jett", LastName = "Mitchell", BirthDate = new DateTime(1976,12,8), Married = true },
                    new Employee { FirstName = "Garrick", LastName = "Stiedemann", BirthDate = new DateTime(1985,1,9), Married = false },
                    new Employee { FirstName = "Hettie", LastName = "Runte", BirthDate = new DateTime(1981,7,2), Married = true }
                }
            };
        }
        public IDialogService EditEmployeeService { get { return GetService<IDialogService>(); } }

        [Command]
        public void EditEmployee(object item) {
            if (item != null && EditEmployeeService != null) {
                EditEmployeeService.ShowDialog(MessageButton.OK, "Edit Employee", item);
            }
        }

    }
}
