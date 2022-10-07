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
        public string NumberWZ { get; set; }
        public int FirmId { get; set; }
        public virtual FirmModel Firm { get; set; }
        public DateTime date { get; set; }
        public byte[] PdfFile { get; set; }
    }
}
