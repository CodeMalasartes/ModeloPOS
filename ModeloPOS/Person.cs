using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloPOS
{
    public class Person : Auditable
    {
        protected int PersonId { get; set; }
        protected string PersonName { get; set; }

    }

 }
