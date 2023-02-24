Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace PropertyGridEditor_Attribute

    Public Class Department

        <Display(Name:="Department Name")>
        Public Property Name As String

        <TypeConverter(GetType(ExpandableObjectConverter))>
        <PropertyGridEditor(TemplateKey:="PropertyTemplate")>
        Public Property Location As Location

        <PropertyGridEditor(TemplateKey:="CollectionDefinitionTemplate")>
        Public Property Employees As ObservableCollection(Of Employee)
    End Class

    <PropertyGridEditor(TemplateKey:="ButtonEditTemplate")>
    Public Class Employee
        Inherits BindableBase

        Public Property FirstName As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property LastName As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property BirthDate As Date
            Get
                Return GetValue(Of Date)()
            End Get

            Set(ByVal value As Date)
                SetValue(value)
            End Set
        End Property

        Public Property Married As Boolean
            Get
                Return GetValue(Of Boolean)()
            End Get

            Set(ByVal value As Boolean)
                SetValue(value)
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return FirstName & " " & LastName
        End Function
    End Class

    Public Class Location

        Public Property Country As String

        Public Property City As String

        Public Property Adress As String

        Public Property ZIP As Integer
    End Class
End Namespace
