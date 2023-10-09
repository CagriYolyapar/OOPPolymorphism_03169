using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism_0.Entities
{
    public class Bateri : Enstruman
    {
        public override string Materyal
        {
            get
            {
                return _materyal;
            }
            set
            {
                if(value.Length < 6)
                {
                    throw new Exception("Lutfen en az 6 karakter giriniz");
                }
                _materyal = value;
            }


        }
    }
}
