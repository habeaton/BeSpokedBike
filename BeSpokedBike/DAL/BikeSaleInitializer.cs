using BeSpokedBike.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeSpokedBike.DAL
{
    public class BikeSaleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BikeSaleContext>
    {
        Products products;
        protected override void Seed(BikeSaleContext context)
        {
            var products = new List<Products>
            {
                new Products{ ProductsID= 1, Name="Marlin", Manufacturer="Gary Fisher", Style="Mountain Bike", PurchasePrice=299.99M, SalePrice=499.99M, QtyOnHand=5, CommissionPercentage=3},
                new Products{ ProductsID= 2, Name="Fuel EX 5", Manufacturer="Trek", Style="Mountain Bike", PurchasePrice=1599.99M, SalePrice=2099.99M, QtyOnHand=3, CommissionPercentage=5},
                new Products{ ProductsID=3, Name="Domane SL 5", Manufacturer="Trek", Style="Road Bike", PurchasePrice=1999.99M, SalePrice=2899.99M, QtyOnHand=5, CommissionPercentage=3},
                new Products{ ProductsID=4, Name="Emonda SLR 9", Manufacturer="Trek", Style="Road Bike", PurchasePrice=9999.99M, SalePrice=11999.99M, QtyOnHand=2, CommissionPercentage=6}
            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var salesperson = new List<Salesperson>
            {
                new Salesperson{ SalespersonID= 1, FirstName="Sarah", LastName="Alexander", Address="1234 Oxford, Lake Orion, MI, 48236", Phone="248-391-1567", StartDate=DateTime.Parse("2000-04-15"), TerminationDate="", Manager="John Doe"},
                new Salesperson{ SalespersonID= 2, FirstName="Nancy", LastName="Smith", Address="5432 Flintridge, Grosse Point Woods, AL, 35111", Phone="248-586-3456", StartDate=DateTime.Parse("2010-02-20"), TerminationDate="2018-09-13", Manager="Sally Jones"},
                new Salesperson{ SalespersonID= 3, FirstName="Chris", LastName="Jones", Address="987 Packard, Ann Arbor, MI, 48189", Phone="248-678-0965", StartDate=DateTime.Parse("2015-01-30"), TerminationDate="", Manager="John Doe"}
            };

            salesperson.ForEach(sp => context.Salesperson.Add(sp));
            context.SaveChanges();

            var customer = new List<Customer>
            {
                new Customer{ CustomerID=1, CustFirstName="Stacy", CustLastName="Long", CustAddress="567 LakeView, Whitmore Lake, GA, 30089", CustPhone="248-568-7654", StartDate="2018-04-05"},
                new Customer{ CustomerID=2, CustFirstName="Harry", CustLastName="Russell", CustAddress="432 Ridge, Greeley, CO, 20098", CustPhone="586-568-0934", StartDate="2017-02-19"}
            };

            customer.ForEach(c => context.Customer.Add(c));
            context.SaveChanges();

            var sales = new List<Sales>
            {
                new Sales{ SalesID=1, ProductName="Fuel EX 5", SalespersonName = "Sarah Alexander", CustomerName = "Stacy Long", SalesDate = DateTime.Parse("2018-02-06"), SalePrice = 2099.99M, CommissionPercentage=5},
                new Sales { SalesID=2, ProductName="Marlin", SalespersonName = "Sarah Alexander", CustomerName = "Linda Short", SalesDate = DateTime.Parse("2018-03-16"), SalePrice = 499.99M, CommissionPercentage=3},
                new Sales{ SalesID=3, ProductName="Domane SL 5", SalespersonName="Chris Jones", CustomerName="Harry Russell", SalesDate= DateTime.Parse("2017-12-19"), SalePrice = 2899.99M, CommissionPercentage=3},
                new Sales{ SalesID=4, ProductName="Emonda SLR 9", SalespersonName="Chris Jones", CustomerName="Penny Miles", SalesDate= DateTime.Parse("2017-11-07"), SalePrice = 11999.99M, CommissionPercentage=6}
            };

            sales.ForEach(s => context.Sales.Add(s));
            context.SaveChanges();

            var discount = new List<Discount>
            {
                new Discount{ DiscountID=1, ProductName="Domane SL 5", BeginDate=DateTime.Parse("2018-11-01"), EndDate=DateTime.Parse("2018-11-15"), DiscountPercentage=15},
                new Discount{ DiscountID=2, ProductName="Emonda SLR 9", BeginDate=DateTime.Parse("2018-12-01"), EndDate=DateTime.Parse("2018-12-15"), DiscountPercentage=20}
            };

            discount.ForEach(d => context.Discount.Add(d));
            context.SaveChanges();

            var commission = new List<Commission>
            {
                new Commission{ CommissionID=1, Salesperson="Sarah Alexander", CommissionAmountQ1=4478.45M, CommissionAmountQ2=5390.12M, CommissionAmountQ3=2904.05M, CommissionAmountQ4=8348.45M},
                new Commission{ CommissionID=2, Salesperson="Chris Jones", CommissionAmountQ1=7934.87M, CommissionAmountQ2=4783.90M, CommissionAmountQ3=8943.23M, CommissionAmountQ4=6205.09M}
            };

            commission.ForEach(co => context.Commision.Add(co));
            context.SaveChanges();
        }
    }
}