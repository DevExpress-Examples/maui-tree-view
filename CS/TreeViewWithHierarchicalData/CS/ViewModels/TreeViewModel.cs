using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Maui.ApplicationModel.DataTransfer;
using System.IO;
using Microsoft.Maui.Storage;
using DevExpress.Maui.Core.Internal;
using TreeView.Data; 

namespace TreeViewWithHierarchicalData;

public class TreeViewModel {
    public ObservableCollection<ReportLibraryNode> Nodes => root.Nodes;
    
    public TreeViewModel() {
        root = ReportLibraryData.Generate();
    }

    ReportLibraryNode root;
}
