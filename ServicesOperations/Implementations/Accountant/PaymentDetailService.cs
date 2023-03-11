using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Accountant;

namespace ServicesOperations.Implementations.Accountant
{
    public class PaymentDetailService : IPaymentDetailService
    {
        ITable<tblstudent_payment_details> payrepo; 

        public void AddPaymentDetail(tblstudent_payment_details payment)
        {
            payrepo.create(payment);
        }

        public void DeletePaymentDetail(int payment_id)
        {
            payrepo.delete(payment_id);
        }

        public List<tblstudent_payment_details> GetAllPaymentDetails()
        {
            return payrepo.GetAll();
        }

        public tblstudent_payment_details GetPaymentDetail(int payment_id)
        {
            return payrepo.GetById(payment_id);
        }

        public void UpdatePaymentDetail(tblstudent_payment_details payment)
        {
            payrepo.update(payment);
        }
    }
}
