Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System
Imports System.Collections.ObjectModel

Namespace PropertyGridEditor_Attribute

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property Department As Department

        Public Sub New()
            Department = New Department With {.Name = "Marketing", .Location = New Location With {.Country = "USA", .City = "Seattle", .Adress = "11th Ave. N.E.", .ZIP = 4726}, .Employees = New ObservableCollection(Of Employee)() From {New Employee With {.FirstName = "Jett", .LastName = "Mitchell", .BirthDate = New DateTime(1976, 12, 8), .Married = True}, New Employee With {.FirstName = "Garrick", .LastName = "Stiedemann", .BirthDate = New DateTime(1985, 1, 9), .Married = False}, New Employee With {.FirstName = "Hettie", .LastName = "Runte", .BirthDate = New DateTime(1981, 7, 2), .Married = True}}}
        End Sub

        Public ReadOnly Property EditEmployeeService As IDialogService
            Get
                Return GetService(Of IDialogService)()
            End Get
        End Property

        <Command>
        Public Sub EditEmployee(ByVal item As Object)
            If item IsNot Nothing AndAlso EditEmployeeService IsNot Nothing Then
                EditEmployeeService.ShowDialog(MessageButton.OK, "Edit Employee", item)
            End If
        End Sub
    End Class
End Namespace
