using System;
using System.Collections.Generic;

namespace HVACProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ... rest of your code
            {
                Console.WriteLine("==================================================");
                Console.WriteLine("   HVAC Redesign Portal - Final System Test       ");
                Console.WriteLine("==================================================\n");

                // 1. Instantiate the new Manager component
                InventoryManager manager = new InventoryManager();

                // 2. Create a mix of base units and extended (smart) units
                HVACUnit standardUnit1 = new HVACUnit("Trane", "XR14", "AC Only", 3.0, 16.0);
                HVACUnit standardUnit2 = new HVACUnit("Lennox", "ML14XC1", "AC Only", 2.5, 14.0);
                SmartHVACUnit smartUnit1 = new SmartHVACUnit("Carrier", "Infinity 26", "Heat Pump", 3.5, 24.0, isWifiEnabled: true);
                SmartHVACUnit smartUnit2 = new SmartHVACUnit("Daikin", "Fit", "Heat Pump", 4.0, 18.0, isWifiEnabled: false);

                // 3. Add them to the system using the manager
                Console.WriteLine("--- Loading Inventory ---");
                manager.AddUnit(standardUnit1);
                manager.AddUnit(standardUnit2);
                manager.AddUnit(smartUnit1);
                manager.AddUnit(smartUnit2);
                Console.WriteLine();

                // 4. Test the ViewAllUnits method
                Console.WriteLine("--- Current System Inventory ---");
                List<HVACUnit> currentInventory = manager.ViewAllUnits();
                foreach (HVACUnit unit in currentInventory)
                {
                    // Note: We use unit.GetType().Name to show if it's a base HVACUnit or a SmartHVACUnit
                    Console.WriteLine($"{unit.Brand} {unit.ModelNumber} | Type: {unit.GetType().Name} | Capacity: {unit.Tonnage} Tons");
                }

                // 5. Test the RunGlobalDiagnostics method
                manager.RunGlobalDiagnostics();

                Console.WriteLine("\n==================================================");
                Console.ReadLine(); // Keeps the console window open until you press Enter
            }
        }
    }
}