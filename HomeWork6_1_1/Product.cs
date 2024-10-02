namespace HomeWork6_1_1;

public class Product {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }
    public string Description {  get; set; }
    public int Quantity {  get; set; }

    public string ToString() {
        return $"{Id} - {Name} - {Cost} - {Description} - {Quantity}";
    }
}
