namespace lab2api;

using System;

class LiquidContainer : Container {
    private int capacity;

    public LiquidContainer(string number, int weight, int height, int emptyWeight, int depth, int maxLoad, int capacity) : base(number, weight, height, emptyWeight, depth, maxLoad) {
        this.capacity = capacity;
    }

    public override void Load(int cargoWeight) {
        if (cargoWeight > capacity) {
            throw new OverfillException($"Przepełnienie kontenera płynów {number}");
        }
        base.Load(cargoWeight);
    }

    public override void NotifyDanger(string containerNumber) {
        Console.WriteLine($"Zagrożenie w kontenerze płynów: {containerNumber}");
    }
}
