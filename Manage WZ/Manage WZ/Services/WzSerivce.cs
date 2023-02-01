using Manage_WZ.Model;

namespace Manage_WZ.Services
{
    public class WzSerivce
    {
        internal static async Task AddWz(int firmId,FirmModel firm,Model.Type type,string description,string fvNumber,string wzNumber, byte[] scan,DateTime wzDate,DateTime fvDate,DateTime delDate)
        {
            using(var context = new DatabaseContext())
            {
                var WZ = new WzModel()
                {
                    dateDelivery = delDate,
                    dateFZ = fvDate,
                    dateWZ = wzDate,
                    Description = description,
                    Firm = firm,
                    NumberWZ = wzNumber,
                    FirmId = firmId,
                    PdfFile = scan,
                    type = type,
                    NumberFv = fvNumber,
                };
                context.Wzs.Add(WZ);
                if (await context.SaveChangesAsync() > 0)
                {
                    await Task.CompletedTask;
                }
                else
                    throw new Exception("Błąd zapisu danych do bazy");
            }
        }
    }
}
