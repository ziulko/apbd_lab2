namespace lab2api;

class ContainerShip {
    private List<Container> containers;
    private int maxSpeed;
    private int maxContainerCount;

    public ContainerShip(int maxSpeed, int maxContainerCount) {
        this.maxSpeed = maxSpeed;
        this.maxContainerCount = maxContainerCount;
        containers = new List<Container>();
    }

    public void AddContainer(Container container) {
        if (containers.Count < maxContainerCount) {
            containers.Add(container);
        }
        else {
            Console.WriteLine("Przekroczono maksymalną liczbę kontenerów na statku.");
        }
    }

    public void RemoveContainer(Container container) {
        containers.Remove(container);
    }

    public void DisplayShipInfo() {
        Console.WriteLine($"Maksymalna prędkość statku: {maxSpeed} węzłów");
        Console.WriteLine($"Aktualna liczba kontenerów na statku: {containers.Count}");
    }

    public List<Container> GetContainers() {
        return containers;
    }
}