namespace lab2api;

class Item {
    public string Name { get; set; }
    public double Temperature { get; set; }

    public Item(string name, double temperature) {
        Name = name;
        Temperature = temperature;
    }
}