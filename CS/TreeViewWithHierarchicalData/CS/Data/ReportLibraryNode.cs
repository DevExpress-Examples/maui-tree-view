using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TreeView.Data;

public class ReportLibraryNode {
    public string Name { get; set; }

    public ObservableCollection<ReportLibraryNode> Nodes { get; }

    public ReportLibraryNode() {
        Nodes = new();
    }
}
