namespace lab2api;

abstract class Container : IHazardNotifier {
    public string number;
    public int weight;
    public int height;
    public int emptyWeight;
    public int depth;
    public int maxLoad;
    public int currentLoad;

    public Container(string number, int weight, int height, int emptyWeight, int depth, int maxLoad) {
        this.number = number;
        this.weight = weight;
        this.height = height;
        this.emptyWeight = emptyWeight;
        this.depth = depth;
        this.maxLoad = maxLoad;
        this.currentLoad = 0;
    }

    public virtual void Load(int cargoWeight) {
        if (cargoWeight > maxLoad) {
            throw new OverfillException($"Przepełnienie kontenera {number}");
        }
        currentLoad = cargoWeight;
    }

    public virtual void Unload() {
        currentLoad = 0;
    }

    public abstract void NotifyDanger(string containerNumber);
}