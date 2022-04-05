
using System;
using System.Collections.Generic;

namespace OSSecuryt.BelezaPura.Domain.Entity
{
    public class BodyPart
    {
        public BodyPart()
        {
            Manicure = "Manicure";
            Pedicure = "Pedicure";
            ManicurePedicure = "Completo";
        }
       
        public string Manicure { get; set; }
        public string Pedicure { get; set; }
        public string ManicurePedicure{ get; set; }

        public virtual IList<Servicos> Servicos { get; set; }
    }
}
