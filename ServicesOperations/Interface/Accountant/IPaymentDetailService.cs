using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Accountant
{
    public interface IPaymentDetailService
    {
        void AddPaymentDetail(tblstudent_payment_details payment);
        void UpdatePaymentDetail(tblstudent_payment_details payment);
        void DeletePaymentDetail(int payment_id);
        List<tblstudent_payment_details> GetAllPaymentDetails();
        tblstudent_payment_details GetPaymentDetail(int payment_id);
    }
}
