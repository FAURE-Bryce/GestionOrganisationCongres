using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionOrganisationCongres
{
    public partial class Congressiste
    {
        public override string ToString()
        {
            return this.nom + " " + this.prenom;
        }
    }
}
