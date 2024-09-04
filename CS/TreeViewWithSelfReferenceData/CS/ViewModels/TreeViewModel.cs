using System.Collections.ObjectModel;
using TreeView.SelfReference.Data;

namespace TreeViewWithSelfReferenceData;

public class TreeViewModel {
    public ObservableCollection<Employee> Nodes { get; }
    public TreeViewModel() {
        var r = new EmployeesRepository();
        Nodes = new(r.Employees);
    }
}
