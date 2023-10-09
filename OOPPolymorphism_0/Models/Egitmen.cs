using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0.Models
{
    //Method polymorphism'e girerek override yapıldıgında bilmelisiniz ki orijinal imzasını korumalıdır...Yoksa farklı bir metot olur ve o da overload olsa bile farklı bir metot sayıldıgı icin polymorphism olmaz...
    public class Egitmen:Personel
    {
        public override string ToString() //Aslında buradaki ToString() metodumuz bize Object class'ından gelen bir metottur...Görevi ilgili yapının temsil edildigi bir metin döndürmektir...Bu, ilkel tiplerde veya ilkel tip gibi davranan yapılarda tek bir deger ile temsil edilebilirken  kompleks tiplerde tek bir deger ile temsil edilemedigi icin ilgili yapının adresini cıkartır(Namespace'ini)... Lakin biz bu metodu override ettigimizde onun görevini degiştirerek bu ToString() metodunun istedigimiz gibi davranmasını saglayabiliriz...Mesela bu class'tan bir instance alınıp ListBox'a eklendiğinde  otomatik olarak bu metot calısacaktır ve siz eger degiştirmisseniz sizin istediginiz şekilde nesne temsil edilecektir...
        {
            return $"{Isim} {SoyIsim}";
        }



        public string Deneme { get; set; }
        public override void GorevYap()
        {
            MessageBox.Show("Ders anlat");
            
        }
    }
}
