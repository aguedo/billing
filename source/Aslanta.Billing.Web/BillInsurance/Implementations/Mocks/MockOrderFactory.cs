using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

public static class MockOrderFactory
{
    public static List<Order> CreateOrders(int count)
    {
        var orders = new List<Order>(count);
        for (int i = 0; i < count; i++)
        {
            Order order = CreateOrder();
            orders.Add(order);
        }

        return orders;
    }

    private static Order CreateOrder()
    {
        var order = new Order
        {
            Code = IdGenerator.RandomDateCode(2020, 2024, "", 12),
            Patient = new Patient
            {
                Id = IdGenerator.NextInt,
                FirstName = RandomNamesGenerator.FirstName(),
                LastName = RandomNamesGenerator.LastName(),
                DateOfBirth = RandomDateGenerator.Generate()
            },
            CollectionDate = RandomDateGenerator.Generate(2020, 2024),
            CreationDate = RandomDateGenerator.Generate(2020, 2024),
            ReceivedDate = RandomDateGenerator.Generate(2020, 2024),
            ReportedDate = RandomDateGenerator.Generate(2020, 2024),
            Insurance = new Insurance
            {
                Payer = RandomPayerGenerator.Generate(),
                PolicyNumber = IdGenerator.RandomStringId(12),
                GroupNumber = IdGenerator.RandomStringId(12),
                RelationshipToInsured = "Self"
            }
        };

        int invoiceItemCount = RandomInstance.Random.Next(1, 20);
        List<InvoiceItem> invoiceItems = new List<InvoiceItem>(invoiceItemCount);
        for (int i = 0; i < invoiceItemCount; i++)
        {
            InvoiceItem invoiceItem = RandomInvoiceItemGenerator.CreateInvoiceItem(order);
            invoiceItems.Add(invoiceItem);
        }

        order.AddInvoiceItem(invoiceItems);
        return order;
    }
}


