using Etities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi.";
        public static string CarUpdated = "Araba Güncellendi.";
        public static string CarDeleted = "Araba Silindi.";

        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string BrandDeleted = "Marka Silimdi.";
        public static string InvalidBrand = "Marka Kısa.";

        public static string ColorAdded = "Renk Eklendi.";
        public static string ColorUpdated = "Renk Güncellendi.";
        public static string ColorDeleted = "Renk Silimdi.";
        public static string InvalidColor = "Renk Kısa.";

        public static string UserAdded = "Kullanıcı Eklendi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
        public static string UserDeleted = "Kullanıcı Silimdi.";

        public static string CustomerAdded = "Müşteri Eklendi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string CustomerDeleted = "Müşteri Silimdi.";

        public static string RentalAdded = "Araç Kiralama Oluşturuldu.";
        public static string RentalUpdated = "Araç Kiralama Güncellendi.";
        public static string RentalDeleted = "Araç Kiralama Silimdi.";
        public static string CarInvalid = "Açıklama Geçersiz";
        public static string  MainteanceTime = "Sunucular Bakımda";
        public static string CarsListed = "Araçlar Listelendi";

        public static string Delivery = "Araç Teslim İçin Yola Çıktı";
        public static string InvalidDalivaryTime = "Araç Mesai Saatleri İçinde Teslim Edilcek";
        public static string Rental = "Araç Kiralandı";
        public static string Return =   "Araç Geri Alındı";
        public static string InvalidReturnTime = " Mesai Dışı . 24 Saat Dolmadan Aracınzı Teslim Etmelisinz";
        public static string BigRental = "Kiraladığınız Süre 24 Saati Geçti Ücretlendirme 2 GÜNDEN Hesaplanacaktır";
        public static string AgeInvalid = "Kiralamak İçin  En Az 18 Yaşında Olmalısnız";
        public static string Insufficient = "Hesap Bakiyesi Yetersiz";
    }
}