using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NinjaPies.Domain.OrderingPizza.ValueObjects;

namespace NinjaPies.Domain.Order
{
    public class Order
    {

        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public Payment Payment { get; set; }            // todo: add payment confirmation domain event to this..

        public ICollection<SalesLineItem> SalesLineItems { get; set; }


        // todo: Add ORDER CHARGES.... need way to set these as well. Maybe this isn't a value object?




        // todo: Create Order - Static Method OR via constructor??
        public static Order CreateOrder(int customerId)
        {

            var thisOrder = new Order {CustomerId = customerId, OrderDate = DateTime.Now};
            return thisOrder;
        }

        public Order()
        {            
        }



        public void AddLineItem(SalesLineItem item)
        {
            SalesLineItems.Add(item);
        }



        public void RemoveLineItem(Guid id)
        {
            var itemExists = SalesLineItems.FirstOrDefault(x => x.Id == id);
            if (itemExists != null)
            {
                SalesLineItems.Remove(itemExists);
            }
        }

        
        public void CheckOut(TransferOfItems transferOfItemsOption, Payment payment)
        {

            // if (transferOfItemsOption.Id == TransferType.Delivery) ... then DeliveryLocation is required...


        }

    }

}
