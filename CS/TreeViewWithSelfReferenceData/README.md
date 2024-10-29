# DevExpress .NET MAUI Tree View - Display Information from Self-Referenced Data Structures

This example displays information from self-referenced data structures. To build the tree structure, the data source should contain [`KeyFieldName`](https://docs.devexpress.com/MAUI/DevExpress.Maui.TreeView.SelfReferenceTreeDescription.KeyFieldName) and [`ParentFieldName`](https://docs.devexpress.com/MAUI/DevExpress.Maui.TreeView.SelfReferenceTreeDescription.ParentFieldName) fields with the same data type. The `KeyFieldName` value of a parent node is equal to the `ParentFieldName` value of a child node in a tree structure. Refer to the following help topic for implementation details: [Tree View - Display Self-Referenced Data](https://docs.devexpress.com/MAUI/404899/tree-view/display-hierarchical-data#self-referenced-data-structure).

<img src="./Images/tree-view-selfreference-data.png" width="50%" />

## Files to Review

* [MainPage.xaml](./CS/MainPage.xaml)
* [TreeViewModel.cs](./CS/ViewModels/TreeViewModel.cs)
* [Employee.cs](./CS/Data/Employee.cs)
* [EmployeesRepository.cs](./CS/Data/EmployeesRepository.cs)

## More Examples

* [Tree View - Display Information from Hierarchical Data Structures](../TreeViewWithHierarchicalData/)
