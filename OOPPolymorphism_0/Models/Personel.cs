using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0.Models
{
    public class Personel
    {
         


        public string Isim { get; set; }
        public virtual string SoyIsim { get; set; }
        public virtual void GorevYap() //Biz bu metoda virtual keyword'u vererek onun dilersek miras verildigi yerlerde degişik görev yapma imkanını saglamıs olduk...
        {
            MessageBox.Show("Calıs");
        }
    }
}
