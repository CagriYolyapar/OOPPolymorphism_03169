using OOPPolymorphism_0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPolymorphism_0
{
    public partial class Form1 : Form
    {

        /*
         * Inheritence prensibinde bir Base Class'ın erişim belirteci miras verdigi class'lardan düsük olamaz...
         
               Siz Inheritance prensibini uygulamak icin illa Encapsulation prensibini uygulamak zorunda degilsiniz...Siz aynı zamanda Encapsulation prensibini uygulamak icin de Inheritance kullanmak zorunda degilsiniz...Encapsulation , INheritance olmadan rahatca kullanılabilecegi gibi Inheritance de Encapsulation olmadan rahatca kullanılabilir...

        Ancak Polymorphism prensibi icin mecburi önce Inheritance olmalıdır...

        ----------------------Polymorphism(Cok Bicimlilik)----------------------------
         
         Diger sınıflara miras veren sınıfımın (Base Class'ın) yapıları tamamıyla türeyen sınıfa(child class'a) aktarılacaktır... Ancak base class'taki yapılardan bazıları farklı sınıflarda farklı şekillerde davranmak isteyebilir... Mesela bir Karakter sınıfı düsünün ve bu Class'ta saldır metodumuz olsun...BU Karakter class'ından miras alan 3 tane sınıf olsun (Büyücü, Okcu, Sovalye) .. Bu miras alan sınıflarımızın her biri Saldır metodunu farklı bir şekilde kullanmak isteyebilir... Bu durumda Saldır() metodunun polymorphism prensibine girmesi gerekir...Yani bu metodun virtual keyword'u ile işaretlenmesi gerekir. İsteyen bir sınıf metodun orijinal halini kullanabilir...İsteyen bir sınıf da metodu degişik bir şekilde kullanabilir...

        Polymorphism'de elinizde olan metodun kullanılacak temel bir işlevi vardır ama baska yerde bu işlev siz isterseniz degişebilir...Polymorphism icin temel bir görevin olması gereklidir...

        Polymorphism icin öncelikle base class'ta tanımlanan yapının bu prensibe maruz kalacagı belirtilmek zorundadır...Bunu da ilgili yapıda virtual keyword'u kullanarak yaparız...Bu virtual keyword'u yapıya su anlamı kadar : "Bu yapı, miras verilen yerde istenirse oldugu gibi kullanılabilir, istenirse de degiştirilebilir"...virtual keyword2u miras verilecek sınıfta o yapının görevini degiştirme imkanını override dedigimiz bir keyword ile sunar...Yani ilgili yapıyı miras alan Class'ta o yapının görevini degiştirmek istiyorsak önce override yazarak ilgili yapıyı deigiştirmek istedigimizi bildiririz...Ama tabii ki bu degişiklik sadece override yazdıgımız(ilgili miras alan Class'ta) olacaktır...Base Class'ta metot hala orijinal davranısını korur...


        Virtual asamasını gectikten sonra türeyen sınıfta degişik şekilde kullanmak istedigimiz metodu getirmek icin override keyword'unu yazıp bir bosluk bırakırsanız virtual olarak işaretlenmiş metotlar karsınıza gelip size büyük bir yazım kolaylıgı saglayacaktır...Polymorphism zorunlu bir şey degildir siz sadece bir yapının görevini mrias verilen yerde degiştirmek isterseniz kullanırsınız...

        virtual keyword'unu sadece bir metoda veya bir property'e verebilirsiniz...Ancak virtual keyword'unu field'lara yazamazsınız...CÜnkü virtual "istersen bunun görevini degiştirebilirsin" demektir...Degişkenler ise görev barındırmaz....Degişkenler deger barındırır...


        virtual keyword'unu private erişim belirtecleri ile kullanılamaz...

         
         
         
         
         */





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Personel> personeller = new List<Personel>();
            //Egitmen egt = new Egitmen();
            //egt.Isim = "Cagri";
            //egt.SoyIsim = "Yolyapar";
            //personeller.Add(egt);
           
            //foreach (Personel item in personeller)
            //{
            //    item.GorevYap();
            //}

            Egitmen egt = new Egitmen();
            egt.Isim = "Cagri";
            egt.SoyIsim = "Yolyapar";
            lstSonuc.Items.Add(egt); //egt.ToString();

          
        }
    }
}
