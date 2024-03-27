namespace lab2api;

class ContainerManagementSystem {
    private ContainerShip ship;
    private HashSet<Container> allContainers;

    public ContainerManagementSystem(int maxSpeed, int maxContainerCount) {
        ship = new ContainerShip(maxSpeed, maxContainerCount);
        allContainers = new HashSet<Container>();
    }

    public void LoadContainerToShip(Container container) {
        ship.AddContainer(container);
        allContainers.Add(container);
    }

    public void UnloadContainerFromShip(Container container) {
        ship.RemoveContainer(container);
    }

    public void ReplaceContainerOnShip(string containerNumber, Container newContainer) {
        foreach (Container container in ship.GetContainers()) {
            if (container.number == containerNumber) {
                ship.RemoveContainer(container);
                allContainers.Remove(container);
                ship.AddContainer(newContainer);
                allContainers.Add(newContainer);
                break;
            }
        }
    }

    public void MoveContainerBetweenShips(string containerNumber, ContainerManagementSystem destinationSystem) {
        Container containerToMove = null;
        foreach (Container container in allContainers) {
            if (container.number == containerNumber) {
                containerToMove = container;
                break;
            }
        }
        if (containerToMove != null) {
            UnloadContainerFromShip(containerToMove);
            destinationSystem.LoadContainerToShip(containerToMove);
        }
        else {
            Console.WriteLine($"Kontener o numerze {containerNumber} nie został znaleziony.");
        }
    }

    public void DisplayContainerInfo(string containerNumber) {
        foreach (Container container in allContainers) {
            if (container.number == containerNumber) {
                Console.WriteLine($"Informacje o kontenerze {containerNumber}:");
                Console.WriteLine($"Typ: {container.GetType().Name}");
                Console.WriteLine($"Waga: {container.weight}");
                Console.WriteLine($"Wysokość: {container.height}");
                Console.WriteLine($"Waga własna: {container.emptyWeight}");
                Console.WriteLine($"Głębokość: {container.depth}");
                Console.WriteLine($"Maksymalna ładowność: {container.maxLoad}");
                Console.WriteLine($"Aktualny ładunek: {container.currentLoad}");
                break;
            }
        }
    }

    public void DisplayShipInfo() {
        ship.DisplayShipInfo();
    }
}