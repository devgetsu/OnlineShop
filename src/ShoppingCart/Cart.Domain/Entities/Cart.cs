using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart.Domain.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public long Price { get; set; }
    }
}
