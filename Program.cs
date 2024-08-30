using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("atm ye hoşgeldiniz");
            Console.WriteLine("kartınızı atm ye sokunuz");
            int bakiye = 10000;
            int şifre = 1234;
            Console.WriteLine("lütfen şifreyi giriniz");
            int kartşifresi = Convert.ToInt32(Console.ReadLine());
            if (şifre == kartşifresi)
            {

                Console.WriteLine("kart şifreniz doğrudur.hoşgeldiniz.sayın esra derici.");
                Console.WriteLine("1.para yatırma 2.kredi kartı işlemleri 3.para gönderme 4.eğitim ödemeleri");
                Console.WriteLine("yapmak istediğiniz işlemi seçin");
                int parayatırma = Convert.ToInt32(Console.ReadLine());
                if (parayatırma == 1)
                {
                    Console.WriteLine("para yatırma hoşgeldiniz.");
                    Console.WriteLine("yatırmak istediğiniz miktarı girin");
                    int yatırılacakpara = Convert.ToInt32(Console.ReadLine());
                    bakiye = yatırılacakpara + bakiye;
                    Console.WriteLine("mevcut bakiye: " + bakiye);


                }
                else if (parayatırma == 2)
                {
                    Console.WriteLine("kredi kartı işlemlerine hoşgeldiniz");
                    int borç = 6000;
                    Console.WriteLine("30 ağustos da ödenmesi gereken " + borç + " tl borç vardır.");
                    Console.WriteLine("kredi kartı borcunuzu ödemek isterseniz 1 basın");
                    int kartcevap = Convert.ToInt32(Console.ReadLine());

                    if (kartcevap == 1)
                    {

                        if (bakiye >= borç)
                        {
                            Console.WriteLine("borç ödenmiştir.teşekkürler");
                            bakiye = bakiye - borç;
                            Console.WriteLine("mevcut bakiye: " + bakiye);


                        }
                        else
                        {
                            Console.WriteLine("yetersiz bakiye");
                        }
                    }
                    else
                    {
                        Console.WriteLine("çıkış yapılıyor");
                    }
                }
                else if (parayatırma == 3)
                {
                    Console.WriteLine("para transferleri menüsüne hoş geldiniz");
                    Console.WriteLine("ödeme yapılacak ibanı giriniz");
                    long iban = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("ad soyad bilgisini giriniz");
                    string ad_soyad = Console.ReadLine();
                    Console.WriteLine("göndermek istediğiniz miktar nedir");
                    int gönderilecekpara = Convert.ToInt32(Console.ReadLine());
                    if (bakiye >= gönderilecekpara)
                    {
                        Console.WriteLine("para transferi gerçekleşmiştir");
                        Console.WriteLine("ad_soyad  adlı kişiye  " + gönderilecekpara + " TL gönderilmiştir");
                        bakiye = bakiye - gönderilecekpara;
                        Console.WriteLine("kalan bakiyeniz" + bakiye);
                    }
                    else
                    {
                        Console.WriteLine("yetersiz bakiye");

                    }

                }

                else if (parayatırma == 4)
                {
                    Console.WriteLine("eğitimin menüsüne hoşgeldiniz");
                    Console.WriteLine("1-yks 2-kpss 3 yds");
                    int karar = Convert.ToInt32(Console.ReadLine());
                    int ücret = 500;
                    int ücret2 = 1000;
                    int ücret3 = 1000;
                    if (karar == 1)
                    {


                        if (bakiye >= ücret)
                        {
                            Console.WriteLine("yks ödemesi yapılmıştır");
                            bakiye = bakiye - ücret;
                            Console.WriteLine("kalan bakiyeniz" + bakiye);


                        }
                        else
                        {
                            Console.WriteLine("yetersiz bakiye");
                        }


                    }
                    else if (karar == 2)
                    {
                        if (bakiye >= ücret)
                        {
                            Console.WriteLine("kpss ödemesi yapılmıştır");
                            bakiye = bakiye - ücret2;
                            Console.WriteLine("kalan bakiyeniz" + bakiye);
                        }
                        {

                            Console.WriteLine("yetersiz bakiye");
                        }


                    }
                    else if (karar == 3)
                    {
                        if (bakiye >= ücret)
                        {
                            Console.WriteLine("yds ödemesi yapılmıştır");
                            bakiye = bakiye - ücret3;
                            Console.WriteLine("kalan bakiyeniz" + bakiye);
                        }
                        else
                        {
                            Console.WriteLine("yetersiz bakiye");
                        }

                    }
                    else
                    {
                        Console.WriteLine("hatalı tercih yaptınız");

                    }


                }

            }


            Console.ReadLine();
        }


    }
 }
   
