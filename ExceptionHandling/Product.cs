using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static ExceptionHandling.Program;

namespace ExceptionHandling
{
    public class Product
    {
      

        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Rating { get; set; }

        
        public Product(int id, decimal price, string name, string manufacturer, int rating)
        {
            Validate(id, price, name, manufacturer, rating);
            Id = id;
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
            Rating = rating;
        }

        public void Validate (int idValue, decimal priceValue, string nameValue, string manufacturerValue, int ratingValue) 
        {
            
            
                Ensure.IsPositive(idValue);
                Ensure.IsNonNegative(priceValue);
            Ensure.IsNotNullOrEmpty(nameValue);
            Ensure.IsNotNullOrWhiteSpace(manufacturerValue);
            Ensure.IsInRange(ratingValue, 0, 5);



        }
    }
}
