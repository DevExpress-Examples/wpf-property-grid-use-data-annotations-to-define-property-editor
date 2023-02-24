using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PropertyGridEditor_Attribute {
    public class Department {
        [Display(Name = "Department Name")]
        public string Name { get; set; }
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [PropertyGridEditor(TemplateKey = "PropertyTemplate")]
        public Location Location { get; set; }
        [PropertyGridEditor(TemplateKey = "CollectionDefinitionTemplate")]
        public ObservableCollection<Employee> Employees { get; set; }
    }

    [PropertyGridEditor(TemplateKey = "ButtonEditTemplate")]
    public class Employee : BindableBase {
        public string FirstName { get { return GetValue<string>(); } set { SetValue(value); } }
        public string LastName { get { return GetValue<string>(); } set { SetValue(value); } }
        public DateTime BirthDate { get { return GetValue<DateTime>(); } set { SetValue(value); } }
        public bool Married { get { return GetValue<bool>(); } set { SetValue(value); } }

        public override string ToString() {
            return FirstName + " " + LastName;
        }
    }
    public class Location {
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int ZIP { get; set; }
    }
}
