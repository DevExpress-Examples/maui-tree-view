using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TreeView.Data;

public static class ReportLibraryData {
    public static ReportLibraryNode Generate() {
        var root = new ReportLibraryNode();
        var orders = new ReportLibraryNode() { Name = "Orders" };
        var customers = new ReportLibraryNode() { Name = "Customers" };
        var employees = new ReportLibraryNode() { Name = "Employees" };
        var marketResearch = new ReportLibraryNode() { Name = "Market Research" };
        var barCodes = new ReportLibraryNode() { Name = "Bar Codes" };
        var crossBand = new ReportLibraryNode() { Name = "Cross Band" };
        var realLife = new ReportLibraryNode() { Name = "Real-Life" };
        var products = new ReportLibraryNode() { Name = "Products" };
        var sales = new ReportLibraryNode() { Name = "Sales" };
        var northwindTraders = new ReportLibraryNode() { Name = "Northwind Traders" };

        orders.Nodes.Add(new ReportLibraryNode() { Name = "Detail.pdf" });
        orders.Nodes.Add(new ReportLibraryNode() { Name = "Summary.pdf" });
        
        customers.Nodes.Add(orders);
        customers.Nodes.Add(new ReportLibraryNode() { Name = "Balance sheet.pdf" });
        customers.Nodes.Add(new ReportLibraryNode() { Name = "Revenue by company.pdf" });

        employees.Nodes.Add(new ReportLibraryNode() { Name = "Arrival card.pdf" });
        employees.Nodes.Add(new ReportLibraryNode() { Name = "Employee comparison.pdf" });
        employees.Nodes.Add(new ReportLibraryNode() { Name = "Employee location.pdf" });
        employees.Nodes.Add(new ReportLibraryNode() { Name = "Employee performance review.pdf" });
        employees.Nodes.Add(new ReportLibraryNode() { Name = "Letter.pdf" });

        marketResearch.Nodes.Add(new ReportLibraryNode() { Name = "Market share.pdf" });
        marketResearch.Nodes.Add(new ReportLibraryNode() { Name = "Polling.pdf" });
        marketResearch.Nodes.Add(new ReportLibraryNode() { Name = "Population.pdf" });
        marketResearch.Nodes.Add(new ReportLibraryNode() { Name = "Profit and loss.pdf" });

        barCodes.Nodes.Add(new ReportLibraryNode() { Name = "All product labels.pdf" });
        barCodes.Nodes.Add(new ReportLibraryNode() { Name = "Code types.pdf" });
        barCodes.Nodes.Add(new ReportLibraryNode() { Name = "Product label.pdf" });

        crossBand.Nodes.Add(new ReportLibraryNode() { Name = "Invoice.pdf" });
        crossBand.Nodes.Add(new ReportLibraryNode() { Name = "Product list.pdf" });

        realLife.Nodes.Add(new ReportLibraryNode() { Name = "Restaurant menu.pdf" });
        realLife.Nodes.Add(new ReportLibraryNode() { Name = "Roll paper.pdf" });

        products.Nodes.Add(barCodes);
        products.Nodes.Add(crossBand);
        products.Nodes.Add(realLife);
        products.Nodes.Add(new ReportLibraryNode() { Name = "Sorting products.pdf" });

        northwindTraders.Nodes.Add(new ReportLibraryNode() { Name = "Catalog.pdf" });
        northwindTraders.Nodes.Add(new ReportLibraryNode() { Name = "Invoice.pdf" });
        northwindTraders.Nodes.Add(new ReportLibraryNode() { Name = "Product list.pdf" });

        sales.Nodes.Add(northwindTraders);
        sales.Nodes.Add(new ReportLibraryNode() { Name = "ACME order overview.pdf" });
        sales.Nodes.Add(new ReportLibraryNode() { Name = "Multi-table order list.pdf" });
        sales.Nodes.Add(new ReportLibraryNode() { Name = "Order details.pdf" });
        sales.Nodes.Add(new ReportLibraryNode() { Name = "Single-table order list.pdf" });
        sales.Nodes.Add(new ReportLibraryNode() { Name = "Summary by year.pdf" });

        root.Nodes.Add(customers);
        root.Nodes.Add(employees);
        root.Nodes.Add(marketResearch);
        root.Nodes.Add(products);
        root.Nodes.Add(sales);

        return root;
    }
}
