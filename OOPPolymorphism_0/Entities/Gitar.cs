using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism_0.Entities
{
    public class Gitar : Enstruman
    {
        public override string Materyal
        {
            get
            {
                return _materyal;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("En az 8 karakter girmelisiniz");
                }
                _materyal = value;
            }

        }

    }
}
