<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/605927629/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1149514)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Property Grid - Use the PropertyGridEditor Attribute to Define a Property Editor

This example demonstrates how to use the `PropertyGridEditor` attribute. This attribute allows you to apply a property definition or property editor template at the data model level.

![image](https://user-images.githubusercontent.com/65009440/221146096-1da027de-5582-492d-a69e-8dbaa19354fa.png)

In this example, **Employee** objects contain an edit button in their editors. This button opens the dialog that allows you to edit object properties.

Templates with the [PropertyDefinition](https://docs.devexpress.com/WPF/15521/controls-and-libraries/property-grid/property-definitions) and [CollectionDefinition](https://docs.devexpress.com/WPF/15719/controls-and-libraries/property-grid/property-definitions/collection-definitions) are applied to the **Location** and **Employees** properties, respectively.

## Files to Review

- [Data.cs](./CS/PropertyGridEditorAttribute/Data.cs) (VB: [Data.vb](./VB/PropertyGridEditorAttribute/Data.vb))
- [ViewModel.cs](./CS/PropertyGridEditorAttribute/ViewModel.cs) (VB: [ViewModel.vb](./VB/PropertyGridEditorAttribute/ViewModel.vb))
- [MainWindow.xaml](./CS/PropertyGridEditorAttribute/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/PropertyGridEditorAttribute/MainWindow.xaml))

## Documentation

- [Property Attributes](https://docs.devexpress.com/WPF/15623/controls-and-libraries/property-grid/property-attributes)
- [Customize Properties](https://docs.devexpress.com/WPF/401044/controls-and-libraries/property-grid/property-definitions/customize-properties)
- [Expandability Customization](https://docs.devexpress.com/WPF/117149/controls-and-libraries/property-grid/expandability-customization)
- [Bind to Property Grid and its Elements](https://docs.devexpress.com/WPF/403662/controls-and-libraries/property-grid/bind-to-property-grid-in-xaml)

## More Examples

- [WPF Property Grid - Apply Data Annotation Attributes](https://github.com/DevExpress-Examples/wpf-property-grid-apply-data-annotation-attributes)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-property-grid-use-data-annotations-to-define-property-editor&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-property-grid-use-data-annotations-to-define-property-editor&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
