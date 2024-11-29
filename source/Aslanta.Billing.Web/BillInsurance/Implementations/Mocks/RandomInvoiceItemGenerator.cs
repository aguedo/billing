using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

public class RandomInvoiceItemGenerator
{
    public static InvoiceItem CreateInvoiceItem(Order order)
    {
        decimal price = Math.Round(new decimal(RandomInstance.Random.NextDouble() * 101), 2);
        var icdCodes = new List<IcdCode>();
        int icdCodeCount = RandomInstance.Random.Next(1, 4);
        for (int i = 0; i < icdCodeCount; i++)
        {
            icdCodes.Add(RandomIcdCodeGenerator.Generate());
        }
        var invoiceItem = new InvoiceItem
        {
            Id = IdGenerator.NextInt,
            Order = order,
            Item = RandomBillableItemGenerator.Generate(),
            CptCode = RandomCptCodeGenerator.Generate(),
            Price = price,
            ActualPrice = price,
            IcdCode1 = icdCodeCount > 0 ? icdCodes[0] : null,
            IcdCode2 = icdCodeCount > 1 ? icdCodes[1] : null,
            IcdCode3 = icdCodeCount > 2 ? icdCodes[2] : null,
            IcdCode4 = icdCodeCount > 3 ? icdCodes[3] : null
        };

        return invoiceItem;
    }
}
