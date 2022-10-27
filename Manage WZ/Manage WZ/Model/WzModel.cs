using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_WZ.Model
{
    internal class WzModel
    {
        public int Id { get; set; }
        public string NumberFv { get; set; }
        public string NumberWZ { get; set; }
        public string Description { get; set; }
        public int FirmId { get; set; }
        public virtual FirmModel Firm { get; set; }
        public DateTime dateWZ { get; set; }
        public DateTime dateFZ { get; set; }
        public DateTime dateDelivery { get; set; }
        public Type type { get; set; }
        public byte[] PdfFile { get; set; }
    }
    public enum Type
    {
        Dostawa,
        Serwis,
        Inne
    }
}
