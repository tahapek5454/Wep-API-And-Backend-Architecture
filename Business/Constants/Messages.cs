using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError ="Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductHasSameNameError="Ürün ismine ait başka bir ürün bulunmaktadır";
        public static string CategoryLimitArriveError = "Farklı Kategori Ekleme Limitine Ulaştınız";
    }
}
