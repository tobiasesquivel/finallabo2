using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEventos
{
    public class Auto
    {
        private double _combustible;
        public event Action CombustibleNegativo;

        public Auto(double combustible)
        {
            this._combustible = combustible;
        }

        public void Andar(double combustibleConsumido)
        {
            this._combustible -= combustibleConsumido;

            if (this._combustible < 0)
            {
                onCombustibleNegativo();
            }
        }

        protected virtual void onCombustibleNegativo()
        {
            this.CombustibleNegativo.Invoke();
        }

    }
}
