using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionHandling.Program;

namespace ExceptionHandling
{
    internal class Product
    {
        private int id;

        public int Id { get => id; set => id = value; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Rating { get; set; }

        public Product()
        {
            
        }
        public Product(int id, decimal price, string name, string manufacturer, int rating)
        {
            Id = id;
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
            Rating = rating;
        }

        public bool Validate()
        {
            try
            {
                Ensure.IsPositive(Id);
                Ensure.IsPositive(Price);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception)
            {
                Console.WriteLine(" The Id and Price value must be positive number ");
            }
            
        }
    }
}
