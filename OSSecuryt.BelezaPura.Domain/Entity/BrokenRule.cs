using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSSecuryt.BelezaPura.Domain.Entity
{
    public class BrokenRule
    {
        public BrokenRule(string field, string description)
        {
            Field = field;
            Description = description;
        }

        public string Field { get; set; }

        public string Description { get; set; }
    }
}
