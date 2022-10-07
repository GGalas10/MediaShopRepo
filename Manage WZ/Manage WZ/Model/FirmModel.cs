using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_WZ.Model
{
    internal class FirmModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<WzModel> WzModels { get; set; }
    }
}
