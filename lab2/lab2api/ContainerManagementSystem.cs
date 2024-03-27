namespace lab2api;

class ContainerManagementSystem {
    private HashSet<Container> containers;

    public ContainerManagementSystem() {
        containers = new HashSet<Container>();
    }

    public void LoadContainer(Container container, int cargoWeight) {
        try {
            container.Load(cargoWeight);
        } catch (OverfillException e) {
            container.NotifyDanger(container.number);
            Console.WriteLine(e.Message);
        }
    }

    public void UnloadContainer(Container container) {
        container.Unload();
    }

    public void AddContainer(Container container) {
        containers.Add(container);
    }

    public void RemoveContainer(Container container) {
        containers.Remove(container);
    }
}
