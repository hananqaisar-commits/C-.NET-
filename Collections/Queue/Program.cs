PrintNames();

Console.WriteLine("------- Task Scheduler (Urgent Work will Prioritize) -----------");
Queue<string> tasks = new Queue<string>();
string? choice = "-1";
string? message = "";

while (choice != "0")
{
    Menu();
    switch (choice)
    {
        case "0":
            Console.Write("Exiting!");
            break;
        case "1":
            if (string.IsNullOrEmpty(message))
            {
                message = "Empty";
            }
            tasks.Enqueue("URGENT-" + message);
            break;
        case "2":
            if (string.IsNullOrEmpty(message))
            {
                message = "Empty";
            }
            tasks.Enqueue(message);
            break;
        case "3":
            Console.WriteLine("\n===== Tasks =====");
            ProcessTasks(tasks);
            break;
        default:
            Console.WriteLine("Invalid option, try again.");
            break;
    }
}

void Menu()
{
    Console.WriteLine("\n1. Urgent Task");
    Console.WriteLine("2. Normal Task");
    Console.WriteLine("3. Process Tasks");
    Console.Write("Choose option 👉 ");
    choice = Console.ReadLine();

    if (choice != "3")
    {
        Console.Write("Enter task message: ");
        message = Console.ReadLine();
    }
}

static void PrintNames()
{
    Queue<string> queue = new Queue<string>();
    queue.Enqueue("Hanan");
    queue.Enqueue("Qaisar");

    while (queue.Count > 0)
    {
        string item = queue.Dequeue();
        Console.WriteLine(item);
    }
}

static void ProcessTasks(Queue<string> tasks)
{
    if (tasks.Count > 0)
    {
        Queue<string> urgentQueue = new Queue<string>();
        Queue<string> normalQueue = new Queue<string>();

        while (tasks.Count > 0)
        {
            var task = tasks.Dequeue();
            if (task.StartsWith("URGENT"))
            {
                urgentQueue.Enqueue(task);
            }
            else
            {
                normalQueue.Enqueue(task);
            }
        }


        foreach (var urgentTask in urgentQueue)
        {
            Console.WriteLine($"   -    Processing: {urgentTask}");
        }
        foreach (var normalTask in normalQueue)
        {
            Console.WriteLine($"   -    Processing: {normalTask}");
        }
    }
    else
    {
        Console.WriteLine("No Tasks");
        return;
    }
}