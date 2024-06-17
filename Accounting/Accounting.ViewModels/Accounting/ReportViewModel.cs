using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.ViewModels.Accounting
{
    public class ReportViewModel
    {
        public long Receive { get; set; }
        public long Pay { get; set; }
        public long AccountBalance { get; set; }
    }
}
