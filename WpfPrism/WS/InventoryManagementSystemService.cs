using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class InventoryManagementSystemService : IInventoryManagementSystemService
    {
        InventoryManagementSystemDbContext _Context = new InventoryManagementSystemDbContext();
        public void Dispose()
        {
            _Context.Dispose();
        }

        public List<Product> GetProducts()
        {
            return _Context.Products.ToList();
        }

        public List<Customer> GetCustomers()
        {
            return _Context.Customers.ToList();
        }

        [OperationBehavior(TransactionScopeRequired =true)]
        public void SubmitOrder(Order order)
        {
            _Context.Orders.Add(order);
            order.OrderItems.ForEach(oi => _Context.OrderItems.Add(oi));
            _Context.SaveChanges();
        }
    }
}
