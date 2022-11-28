namespace Domain.Dto;
public class Orders 
{
    public int id { get; set; }
    public string ProductName { get; set; }
    public string CustomerId { get; set; }
    public DateTime CreateAt { get; set; }
    public int ProductCount { get; set; }
    public int Price { get; set; }
}