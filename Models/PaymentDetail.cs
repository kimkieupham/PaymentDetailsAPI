using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; } /** use as the primary key, which will be unique for every customer*/

        [Column(TypeName = "nvarchar(100)")] /**  nvarrchar(100) will indicate that the card owner name can havee a maximum 100 character */
        public string CardOwnerName { get; set; } /** use to ge the owner card name */

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }

        [Column(TypeName = "nvarchar(5)")] /** we only allow 5 charracter here is because we need to hhave mm/year*/
        public string ExpirationDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string SecurityCode { get; set; }

    }
}
