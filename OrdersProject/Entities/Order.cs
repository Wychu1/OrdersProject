namespace OrdersProject.Entities
{
    public class Order
    {
        public long Id { get; set; }

        public virtual Company Company { get; set; }
        public virtual Product Product { get; set; }
        public virtual Contractor Contractor { get; set; }
        public virtual User User { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public bool PaymentStatus { get; set; }
        public string Seller { get; set; }
        public string Buyer { get; set; }
        

    }
}