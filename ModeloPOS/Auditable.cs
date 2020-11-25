using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloPOS
{
    //Classe usada para registrar quem criou, apagou ou modificou o registro
    public class Auditable
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
