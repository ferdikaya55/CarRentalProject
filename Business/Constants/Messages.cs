using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba günlük fiyatı geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Araçlar listelendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araba başarıyla güncellendi.";
        public static string CarPriceCheck = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";
        public static string BrandsListed = "Araç Markaları Listesi";
        public static string BrandAdded= "Araç Markası Eklendi";
        public static string BrandUpdated = "Araç Markası Güncellendi";
        public static string BrandDeleted= "Araç Markası Silindi";
        public static string ColorAdded = "Araç Rengi Eklendi";
        public static string ColorDeleted = "Araç Rengi Silindi";
        public static string ColorUpdated = "Araç Rengi Güncellendi";
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string RentalSuccess = "Kiralama işlemi başarılı";
        public static string RentalError = "Aracın kiraya verilebilmesi için önce teslim edilmesi gerekir.";
        public static string CarImageLimitExceeded = "Bir araca ait en fazla 5 resim olabilir";


        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string ProductNameAlreadyExists = "Ürün ismi zaten mevcut";
    }
}
