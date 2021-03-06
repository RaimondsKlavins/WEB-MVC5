using System;
using System.ComponentModel.DataAnnotations;
namespace Web_Shop.Models
{
    public class Purchase
    {
        [Key]
        public long PurchaseId { get; set; }

        public string CustomerID { get; set; }

        public string DeliveryAddress { get; set; }

        public string DeliveryCountry { get; set; }

        public string DeliveryPostcode { get; set; }

        public string DeliveryCarrier { get; set; }

        public string DeliveryRecipient { get; set; }

        public string GoodsCode { get; set; }

        public int GoodsQuantity { get; set; }

        public DateTime DateOrder { get; set; }

        public DateTime DateDispatch { get; set; }

        public DateTime DateDelivery { get; set; }
    }
}