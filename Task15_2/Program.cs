using System;
using System.Collections.Generic;

namespace Task15_2
{
    class WarehouseManagement
    {
        static void Main()
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            inventory.Add("A001", 10);  // Ноутбуки
            inventory.Add("B205", 25);  // Смартфоны
            inventory.Add("C307", 15);  // Наушники

            bool hasB205 = inventory.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasB205}");

            inventory["A001"] = 8;

            if (inventory.TryGetValue("C307", out int headphonesCount))
                Console.WriteLine($"Количество наушников: {headphonesCount}");

            inventory["B205"] += 5;

            inventory.Remove("C307");

            Console.WriteLine("Текущие товары:");
            foreach (var item in inventory)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            bool isEmpty = inventory.Count == 0;
            Console.WriteLine($"Список пуст? {isEmpty}");

            inventory.Clear();

            Console.WriteLine($"Количество товаров после очистки: {inventory.Count}");
        }
    }
}