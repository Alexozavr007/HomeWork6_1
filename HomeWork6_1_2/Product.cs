namespace HomeWork6_1_2;

public class Product {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }
    public string Description {  get; set; }
    public int Quantity {  get; set; }

    public override string ToString() {
        return $"{Id} - {Name} - {Cost} - {Description} - {Quantity}";
    }
}
