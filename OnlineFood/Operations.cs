using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineFood1
{
    public class Operations
    {
        OrderContext obj2 = new OrderContext();


        // Create Opreation

        public List<Order> ViewOrder()
        {
            return obj2.orders.ToList();
        }

        //Insert operation

        public void InsertOrder(Order p)
        {
            obj2.orders.Add(p);

            obj2.SaveChanges();
        }

        // Update Operation

        public void UpdateOrder(Order p)

        {
            obj2.orders.Update(p);

            obj2.SaveChanges();
        }

        // Delete Operation

        public void DeleteOrder(int  p)
        {
            obj2.orders.Where(q => q.OrderID == p).ExecuteDelete(); //Total Row

            obj2.SaveChanges();
        }

    }
}
       