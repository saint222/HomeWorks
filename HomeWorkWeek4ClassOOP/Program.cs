using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkWeek4ClassOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Here are some words about our farm...");
            Farm farm = new Farm();
            farm.NameOfTheFarm = "Farmswill";
            farm.TotalGardenbedArea = 100500;
            Console.WriteLine("The name of the farm is " + farm.NameOfTheFarm + ";");
            Console.WriteLine("The total gardenbed area of the farm is " + farm.TotalGardenbedArea + " sq.m.;");
            Console.WriteLine("Here is the list of plants, which are grown up at the farm with such characteristics as the season of planting and harvesting:");
            List<Plant> plants = new List<Plant>();
            Plant potatoe = new Plant { PlantName = "Potatoe", SeasonOfHarvesting = "Spring", SeasonOfPlanting = "Autumn" };
            plants.Add(potatoe);
            Plant carrot = new Plant { PlantName = "Carrot", SeasonOfHarvesting = "Spring", SeasonOfPlanting = "Autumn" };
            plants.Add(carrot);
            Plant onion = new Plant { PlantName = "Onion", SeasonOfHarvesting = "Spring", SeasonOfPlanting = "Autumn" };
            plants.Add(onion);
            for (int i = 0; i < plants.Count; i++)
            {
                Console.WriteLine(plants[i].PlantName + " (" + plants[i].SeasonOfPlanting + " - " + plants[i].SeasonOfHarvesting + ");");
            }
            Console.WriteLine("Here is the list of the farm gardenbeds:");
            List<GardenBed> gardenbeds = new List<GardenBed>();
            GardenBed gardenbed_1 = new GardenBed { GardenbedName = "The potatoe gardenbed", GardenbedSquare = 100.0 };
            gardenbeds.Add(gardenbed_1);
            GardenBed gardenbed_2 = new GardenBed { GardenbedName = "The carrot gardenbed", GardenbedSquare = 50.0 };
            gardenbeds.Add(gardenbed_2);
            GardenBed gardenbed_3 = new GardenBed { GardenbedName = "The onion gardenbed", GardenbedSquare = 25.0 };
            gardenbeds.Add(gardenbed_3);
            for (int i = 0; i < gardenbeds.Count; i++)
            {
                Console.WriteLine(gardenbeds[i].GardenbedName + " (" + gardenbeds[i].GardenbedSquare + " sq.m.);");
            }
            Console.WriteLine("The animals at the farm and products they produce are:");
            List<Animal> animals = new List<Animal>();
            Animal pigs = new Animal { AnimalName = "Pigs", AnimalProduct = "Pork" };
            animals.Add(pigs);
            Animal cows = new Animal { AnimalName = "Cows", AnimalProduct = "Milk" };
            animals.Add(cows);
            Animal chikens = new Animal { AnimalName = "Chikens", AnimalProduct = "Eggs" };
            animals.Add(chikens);

            for (int i = 0; i < animals.Count; i++)

            {
                Console.WriteLine(animals[i].AnimalName + " (" + animals[i].AnimalProduct + ");");
            }
            Console.WriteLine("The products with their weight, produced at the farm, are:");
            List<Product> products = new List<Product>();
            Product milk = new Product { ProductName = "Milk", ProductWeight = 1000 };
            products.Add(milk);
            Product eggs = new Product { ProductName = "Eggs", ProductWeight = 150 };
            products.Add(eggs);
            Product pork = new Product { ProductName = "Pork", ProductWeight = 200 };
            products.Add(pork);
            for (int i = 0; i < products.Count; i++)

            {
                Console.WriteLine(products[i].ProductName + " - " + products[i].ProductWeight + "kg;");
            }

            Console.WriteLine("Here is the list of the farm buildings with such characteristics as their names, square and inhabitants:");
            List<Building> buildings = new List<Building>();
            Building pigsty = new Building { BuildingName = "The pigsty", BuildingSquare = 25.5, AnimalQuantity = 100 };
            buildings.Add(pigsty);
            Building chikenCoop = new Building { BuildingName = "The chiken coop", BuildingSquare = 12.0, AnimalQuantity = 50 };
            buildings.Add(chikenCoop);
            Building cowshed = new Building { BuildingName = "The cowshed", BuildingSquare = 120.0, AnimalQuantity = 200 };
            buildings.Add(cowshed);
            for (int i = 0; i < buildings.Count; i++)

            {
                Console.WriteLine(buildings[i].BuildingName + " (" + buildings[i].BuildingSquare + " sq.m.; " + buildings[i].AnimalQuantity + " animals);");
            }
            Console.ReadLine();
        }


    }

}

