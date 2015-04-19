using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FhirFoxFormBuilder
{
    public partial class UI
    {
        public StructureDefinition StrucDef { get; set; }

        public UI(StructureDefinition StrucDef)
        {
            this.StrucDef = StrucDef;
        }

    }
}
