using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public static class Invoice
    {
        static int InvoiceId { get;}
        static Customer InvoiceCustomer { get;}  
        static Job InvoiceJob { get; }
        static List<WorkTime> InvoiceWorkTimeList { get; }                
    }
}
