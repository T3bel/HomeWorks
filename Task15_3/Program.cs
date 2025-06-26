namespace Task15_3
{
    using System;
    using System.Collections.Generic;

    class SubscriptionSystem
    {
        static void Main()
        {
            var subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine($"Дубликат alice@example.com добавлен? {!subscribers.Add("alice@example.com")}");
            Console.WriteLine($"Дубликат bob@example.com добавлен? {!subscribers.Add("bob@example.com")}");
            Console.WriteLine($"Дубликат charlie@example.com добавлен? {!subscribers.Add("charlie@example.com")}");
            
            Console.WriteLine($"Дубликат alice@example.com добавлен? {!subscribers.Add("alice@example.com")}");

            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {subscribers.Contains("dave@example.com")}");

            var newSubscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "bob@example.com",
            "dave@example.com",
            "eve@example.com"
        };

            subscribers.UnionWith(newSubscribers);

            Console.WriteLine("Подписчики после объединения:");
            foreach (var email in subscribers)
            {
                Console.WriteLine($"- {email}");
            }

            subscribers.IntersectWith(newSubscribers);
            Console.WriteLine("Общие подписчики:");
            foreach (var email in subscribers)
            {
                Console.WriteLine($"- {email}");
            }

            subscribers = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "alice@example.com", "bob@example.com", "charlie@example.com", "dave@example.com", "eve@example.com"
        };

            Console.WriteLine($"Удалили charlie@example.com? {subscribers.Remove("charlie@example.com")}");
            Console.WriteLine($"Всего подписчиков: {subscribers.Count}");

            var testGroup = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "bob@example.com", "eve@example.com" };
            Console.WriteLine($"testGroup является подмножеством? {testGroup.IsSubsetOf(subscribers)}");

            subscribers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {subscribers.Count}");
        }
    }

}
