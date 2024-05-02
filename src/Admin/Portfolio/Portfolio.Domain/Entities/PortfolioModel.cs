using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Entities
{
    public class PortfolioModel
    {
        public Guid Id { get; set; }
        public string Category { get; set; }
        // shu joyida image bilan ishlangan joyi bolishi kere
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
