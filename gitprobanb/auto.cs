using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitprobanb
{
    class auto
    {
        private string modell;
        private int evj;
        private int kilom;
        private string uzema;
        private int ar;

        public auto(string modell, int evj, int kilom, string uzema, int ar)
        {
            this.modell = modell;
            this.evj = evj;
            this.kilom = kilom;
            this.uzema = uzema;
            this.ar = ar;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", modell, evj, kilom, uzema, ar);
        }
    }
}
