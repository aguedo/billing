using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

internal static class RandomPayerGenerator
{
    public static Payer Generate()
    {
        return _payers[RandomInstance.Random.Next(0, _payers.Length)];
    }

    private static Payer[] _payers = [
new Payer { Code = "BCBS", Name = "Blue Cross Blue Shield"},
new Payer { Code = "AET", Name = "Aetna" },
new Payer { Code = "UHC", Name = "UnitedHealthcare" },
new Payer { Code = "HUM", Name = "Humana" },
new Payer { Code = "MCR", Name = "Medicare" },
new Payer { Code = "MCD", Name = "Medicaid" },
new Payer { Code = "ANT", Name = "Anthem" },
new Payer { Code = "KPM", Name = "Kaiser Permanente" },
new Payer { Code = "WLP", Name = "WellPoint" },
new Payer { Code = "TRI", Name = "TriCare" },
new Payer { Code = "CIG", Name = "Cigna" },
new Payer { Code = "HMS", Name = "Health Management Systems" }
    ];
}
