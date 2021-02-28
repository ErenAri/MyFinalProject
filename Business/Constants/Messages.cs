using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Bir kategoriden en fazla 10 ürün eklenir";
        public static string ProductNameAlreadyExists = "Aynı isimde 2 ürün eklenemez";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı 15'den büyük olamaz";
        public static string AuthorizationDenied = "Yetkiniz Yok";
        
    }
}
