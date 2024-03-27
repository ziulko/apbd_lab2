using lab2api;

class Program {
    static void Main(string[] args) {
        ContainerManagementSystem cms = new ContainerManagementSystem(30, 100);
        
        LiquidContainer liquidContainer = new LiquidContainer("KON-L-1", 5000, 200, 300, 150, 10000, 2000);
        GasContainer gasContainer = new GasContainer("KON-G-1", 6000, 250, 350, 170, 12000, 500);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer("KON-C-1", 7000, 220, 320, 160, 15000, "Mięso", 5.0);
        refrigeratedContainer.AddItem("Banany", 3.0);
        refrigeratedContainer.AddItem("Truskawki", 4.0);

        cms.LoadContainerToShip(liquidContainer);
        cms.LoadContainerToShip(gasContainer);
        cms.LoadContainerToShip(refrigeratedContainer);

        Console.WriteLine("Informacje o kontenerach:\n");
        cms.DisplayContainerInfo(liquidContainer.number);
        Console.WriteLine("\n");
        cms.DisplayContainerInfo(gasContainer.number);
        Console.WriteLine("\n");
        cms.DisplayContainerInfo(refrigeratedContainer.number);
        refrigeratedContainer.DisplayItems();
        
        Console.WriteLine("\nInformacje o statku:");
        cms.DisplayShipInfo();
    }
}   