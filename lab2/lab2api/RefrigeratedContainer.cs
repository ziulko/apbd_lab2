namespace lab2api;

class RefrigeratedContainer : Container {
    private List<Item> items;

    public RefrigeratedContainer(string number, int weight, int height, int emptyWeight, int depth, int maxLoad, string productType, double temperature) : base(number, weight, height, emptyWeight, depth, maxLoad) {
        ProductType = productType;
        Temperature = temperature;
        items = new List<Item>();
    }

    public string ProductType { get; set; }
    public double Temperature { get; set; }

    public void AddItem(string itemName, double itemTemperature) {
        items.Add(new Item(itemName, itemTemperature));
    }

    public override void Load(int cargoWeight) {
        if (cargoWeight > maxLoad) {
            throw new OverfillException($"Przepełnienie kontenera chłodniczego {number}");
        }
        base.Load(cargoWeight);
    }

    public override void NotifyDanger(string containerNumber) {
        Console.WriteLine($"Zagrożenie w kontenerze chłodniczym: {containerNumber}");
    }

    public void DisplayItems() {
        Console.WriteLine($"Przedmioty w kontenerze {number}:");
        foreach (var item in items) {
            Console.WriteLine($"- {item.Name}, temperatura: {item.Temperature} stopni");
        }
    }
}