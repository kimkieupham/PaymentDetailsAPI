using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext:DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options) /** Add the contructor by ctor then tab*/
        {

        }
        /** we added this Dbset property for the paymentDetaial model class then after the migration the PaymentDetail table will be created in the SQL serve*/
        public DbSet<PaymentDetail> PaymentDetails { get; set; } /** We add the property for the paymentdetails*/
    }
}
