namespace Zakázky.DB_Class
{

    public class Order
    {
        public int ID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? OrderName { get; set; }
        public OrderType orderType { get; set; }
        public OrderState orderState { get; set; }  
        public string? OrderDescription { get; set; }
        public string? OrderNote { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public int? EmployeeTookOverID { get; set; }
        public Employee? EmployeeTookOver { get; set; }

        public int? CustumerID { get; set; }    
        public Subject? Custumer { get; set; }
        public int? ContractorID { get; set; }
        public Subject? Contractor { get; set; }

        public int? OrderItemID { get; set; }
        public OrderItem? OrderItem { get; set; }

        public decimal? EstimatedTotalCost { get; set; }
        public decimal? TotalCost { get; set; }
        public Boolean IsDeleted { get; set; } = false;

    }
}
