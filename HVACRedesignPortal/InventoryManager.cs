using System;
using System.Collections.Generic;

namespace HVACProject
{
    public class InventoryManager
    {
        private List<HVACUnit> unitDatabase = new List<HVACUnit>();

        public InventoryManager()
        {
        }

        public void AddUnit(HVACUnit unit)
        {
            unitDatabase.Add(unit);
            Console.WriteLine($"[SUCCESS] {unit.Brand} {unit.ModelNumber} added to inventory.");
        }

        public List<HVACUnit> ViewAllUnits()
        {
            return unitDatabase;
        }

        public void RunGlobalDiagnostics()
        {
            Console.WriteLine("\n--- Global System Diagnostics ---");

            if (unitDatabase.Count == 0)
            {
                Console.WriteLine("No units currently in inventory.");
                return;
            }

            foreach (HVACUnit unit in unitDatabase)
            {
                if (unit is IDiagnosable diagnosableUnit)
                {
                    Console.WriteLine(diagnosableUnit.RunSystemDiagnostics());
                }
                else
                {
                    Console.WriteLine($"[SKIPPED] {unit.Brand} {unit.ModelNumber} is a base unit and does not support remote diagnostics.");
                }
            }
        }
    }
}