using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiSample.Models;

namespace WebApiSample.Initializer
{
    public class DataFeeder
    {
        public static int productKey = 0;

        public static List<Product> getProducts()
        {
            List<Product> lstProd = new List<Product>();

            Product lt = new Product();
            productKey = productKey + 1;
            lt.ID = productKey;
            lt.Make = "Apple";
            lt.Model = "I Phone 5";
            lt.Color = "Black";
            lt.Specs = "2 GB RAM";
            lt.ImgPath = "images/I6_Black.jpeg";
            lt.Price = "$200.0";
            lt.OfferPrice = "$190.0";
            lt.Views = 100;
            lt.Description = "SUper Nateral Phone ...................... Random text.................";
            lt.TotalNoOfPurchases = 40;
            lstProd.Add(lt);

            Product lt1 = new Product();
            productKey = productKey + 1;
            lt1.ID = productKey;
            lt1.Make = "Apple";
            lt1.Model = "I Phone 5";
            lt1.Color = "White";
            lt1.Specs = "2 GB RAM";
            lt1.ImgPath = "images/I6_White.jpeg";
            lt1.Price = "$200.0";
            lt1.OfferPrice = "$190.0";
            lt1.Views = 120;
            lt1.TotalNoOfPurchases = 20;
            lt1.Description = "SUper Nateral Phone ...................... Random text.................";
            lstProd.Add(lt1);

            Product lt2 = new Product();
            productKey = productKey + 1;
            lt2.ID = productKey;
            lt2.Make = "Apple";
            lt2.Model = "I Phone 5";
            lt2.Color = "Gold";
            lt2.Specs = "2 GB RAM";
            lt2.ImgPath = "images/I6_Gold.jpg";
            lt2.Price = "$200.0";
            lt2.OfferPrice = "$190.0";
            lt2.Views = 80;
            lt2.TotalNoOfPurchases = 10;
            lt2.Description = "SUper Nateral Phone ...................... Random text.................";
            lstProd.Add(lt2);

            return lstProd;

        }

       
        public static List<CreateAdd> getActiveAdds()
        {
            List<CreateAdd> lstAdds = new List<CreateAdd>();            
            CreateAdd objAdd = new CreateAdd();
            objAdd.AgeGroup = "below 5";
            objAdd.Browser = "IE";
            objAdd.Device = "Android";
            objAdd.Gender = "M";
            objAdd.Region = "TV";
            objAdd.ImageURL =  "images/I6_Black.jpeg";
            lstAdds.Add(objAdd);
            return lstAdds;
        }

        public static List<AddsHistory> getAddsHistory()
        {
            List<AddsHistory> lstAdds = new List<AddsHistory>();
            AddsHistory objAdd = new AddsHistory();
            objAdd.AgeGroup = "below 5";            
            objAdd.Gender = "M";
            objAdd.Region = "TV";
            objAdd.ID = 1;
            objAdd.Views = 20;
            lstAdds.Add(objAdd);

            AddsHistory objAdd1 = new AddsHistory();
            objAdd1.AgeGroup = "10 to 15";
            objAdd1.Gender = "F";
            objAdd1.Region = "RG";
            objAdd1.ID = 2;
            objAdd1.Views = 20;
            lstAdds.Add(objAdd1);
            return lstAdds;
        }


    }
}
