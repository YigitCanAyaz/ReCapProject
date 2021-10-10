using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // Brand - Marka (true)

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandGetById = "Marka görüntülendi";
        public static string BrandsListed = "Markalar listelendi";

        // Brand - Marka (false)

        public static string BrandNotAdded = "Marka eklenemedi";
        public static string BrandNotDeleted = "Marka silinemedi";
        public static string BrandNotUpdated = "Marka güncellenemedi";
        public static string BrandNotGetById = "Marka görüntülenemedi";
        public static string BrandNotsListed = "Markalar listelenemedi";

        // Color - Renk (true)

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorGetById = "Renk görüntülendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsListed = "Renkler Listelendi";

        // Color - Renk (false)

        public static string ColorNotAdded = "Renk eklenemedi";
        public static string ColorNotDeleted = "Renk silienmedi";
        public static string ColorNotUpdated = "Renk güncellenemedi";
        public static string ColorNotGetById = "Renk görüntülenemedi";
        public static string ColorNotsListed = "Renkler listelenemedi";

        // Car - Araba

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarGetById = "Araba görüntülendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar Listelendi";

        // Car - Araba (false)

        public static string CarNotAdded = "Araba eklenemedi";
        public static string CarNotDeleted = "Araba silinemedi";
        public static string CarNotUpdated = "Araba güncellenemedi";
        public static string CarNotGetById = "Araba görüntülenemedi";
        public static string CarNotsListed = "Arabalar listelenemedi";

        // User - Kullanıcı

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserGetById = "Kullanıcı görüntülendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";


        // User - Kullanıcı (false)

        public static string UserNotAdded = "Kullanıcı eklenemedi";
        public static string UserNotDeleted = "Kullanıcı silinemedi";
        public static string UserNotUpdated = "Kullanıcı güncellenemedi";
        public static string UserNotGetById = "Kullanıcı görüntülenemedi";
        public static string UserNotsListed = "Kullanıcılar listelenemedi";

        // User - Özel 

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token yaratıldı";

        // Customer - Müşteri

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerGetById = "Müşteri görüntülendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler Listelendi";

        // Customer - Müşteri (false)

        public static string CustomerNotAdded = "Müşteri eklenemedi";
        public static string CustomerNotDeleted = "Müşteri silinemedi";
        public static string CustomerNotUpdated = "Müşteri güncellenemedi";
        public static string CustomerNotGetById = "Müşteri görüntülenemedi";
        public static string CustomerNotsListed = "Müşteriler listelenemedi";

        // Rental - Kiralama

        public static string RentalAdded = "Kiralık araba eklendi";
        public static string RentalDeleted = "Kiralık araba silindi";
        public static string RentalGetById = "Kiralık araba görüntülendi";
        public static string RentalUpdated = "Kiralık araba güncellendi";
        public static string RentalsListed = "Kiralık arabalar Listelendi";
        public static string RentalCarReturned = "Kiralık araba iade edildi";

        // Rental - Kiralama (false)

        public static string RentalNotAdded = "Kiralık araba eklenemedi";
        public static string RentalNotDeleted = "Kiralık araba silinemedi";
        public static string RentalNotUpdated = "Kiralık araba güncellenemedi";
        public static string RentalNotGetById = "Kiralık araba görüntülenemedi";
        public static string RentalNotsListed = "Kiralık arabalar listelenemedi";

        // CarImage - Kiralama

        public static string CarImageAdded = "Kiralık araba fotoğrafı eklendi";
        public static string CarImageDeleted = "Kiralık araba fotoğrafı silindi";
        public static string CarImageGetById = "Kiralık araba fotoğrafı görüntülendi";
        public static string CarImageUpdated = "Kiralık araba fotoğrafı güncellendi";
        public static string CarImagesListed = "Kiralık araba fotoğrafılar Listelendi";
        public static string CarImageCarReturned = "Kiralık araba fotoğrafı iade edildi";

        // CarImage - Kiralama (false)

        public static string CarImageNotAdded = "Kiralık araba fotoğrafı eklenemedi";
        public static string CarImageNotDeleted = "Kiralık araba fotoğrafı silinemedi";
        public static string CarImageNotUpdated = "Kiralık araba fotoğrafı güncellenemedi";
        public static string CarImageNotGetById = "Kiralık araba fotoğrafı görüntülenemedi";
        public static string CarImageNotsListed = "Kiralık araba fotoğrafılar listelenemedi";
        public static string CarImageCountOfCarError = "Bir arabada en fazla 5 fotoğraf olabilir";
        public static string CarIdIsNotSame = "Araba id aynı değil";

        // Custom

        public static string CarHasAlreadyBeenRented = "Araba zaten kiralanmış";
    }
}
