using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism_0.Entities
{
    public class Enstruman
    {
        //Materyal'in güvenli bir şekilde sadece Gitar  class'ında Encapsulation yapılarak minimum 8 karakter harf alabilmesini saglayın, Bateri class'ında da minimum 6 karakter yapılmasını saglayın...Kod hakimiyeti sizde

        protected string _materyal;
        public virtual string Materyal { get; set; }
        public bool DijitalMi { get; set; }
    }
}
