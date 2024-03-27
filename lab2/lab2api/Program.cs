using lab2api;

class Program {
    static void Main(string[] args) {
        ContainerManagementSystem cms = new ContainerManagementSystem();
        
        LiquidContainer liquidContainer = new LiquidContainer("KON-L-1", 5000, 200, 300, 150, 10000, 2000);
        GasContainer gasContainer = new GasContainer("KON-G-1", 6000, 250, 350, 170, 12000, 500);

        cms.AddContainer(liquidContainer);
        cms.AddContainer(gasContainer);

        cms.LoadContainer(liquidContainer, 1800);
        cms.LoadContainer(gasContainer, 600);

        cms.UnloadContainer(liquidContainer);
        cms.UnloadContainer(gasContainer);
    }
}