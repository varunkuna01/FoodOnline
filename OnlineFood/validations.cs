using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFood1;

namespace Online
{
    public class validations
    {
        public class Operations
        {
            public readonly OrderContext obj2 = new OrderContext();

            public void ValidateAndAddOrder()
            {
                var order = new Order
                {
                    CustomerID = 1,
                    RestaurantID = 1,
                    Status = "Pending",
                    TotalAmount = 10000000000000000.00m // Example value exceeding the range
                };

                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(order, null, null);
                bool isValid = Validator.TryValidateObject(order, validationContext, validationResults, true);

                if (!isValid)
                {
                    foreach (var validationResult in validationResults)
                    {
                        Console.WriteLine(validationResult.ErrorMessage);
                    }
                }
                else
                {
                    Console.WriteLine("Order is valid.");
                    obj2.orders.Add(order);
                    obj2.SaveChanges();
                }
            }

        }
    }
}
