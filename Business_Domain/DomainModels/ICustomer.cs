using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Domain.DomainModels
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Address { get; set; }
        string Zip { get; set; }
        string City { get; set; }
        string CVR { get; set; }
    }
}
