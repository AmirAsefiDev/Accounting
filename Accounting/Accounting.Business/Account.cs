using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Linq;

namespace Accounting.Business
{
    public class Account
    {
        public static ReportViewModel ReportFormMain()
        {
            ReportViewModel rp = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                //DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                //DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                //&& a.DateTitle >= startDate && a.DateTitle <= endDate

                var receive = db.AccountingRepository.Get(a => a.TypeID == 1).Select(a => a.Amount).ToList();
                var pay = db.AccountingRepository.Get(a => a.TypeID == 2).Select(a => a.Amount).ToList();

                rp.Receive = receive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (receive.Sum() - pay.Sum());

            }
            return rp;
        }
    }
}
