namespace lab2api;

using System;

class GasContainer : Container {
    private int capacity;
    private const double LEAVING_PERCENTAGE = 0.05;

    public GasContainer(string number, int weight, int height, int emptyWeight, int depth, int maxLoad, int capacity) : base(number, weight, height, emptyWeight, depth, maxLoad) {
        this.capacity = capacity;
    }

    public override void Unload() {
        base.Unload();
        currentLoad = (int)(capacity * LEAVING_PERCENTAGE);
    }

    public override void NotifyDanger(string containerNumber) {
        Console.WriteLine($"Zagrożenie w kontenerze gazu: {containerNumber}");
    }
}
