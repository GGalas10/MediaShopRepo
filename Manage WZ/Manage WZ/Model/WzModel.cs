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
        public virtual FirmModel Firm { get; set; }
        public byte[] Data { get; set; }
    }
}
