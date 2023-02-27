// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
EingabeGameMode();


static void EingabeGameMode() { 
    Console.WriteLine("Für welchen Spielmodus möchtest du erstellen");
    Console.WriteLine("1 für Path to Glory \n 2 für normal");
    string consoleEingabe = "2";
    try
    {
        consoleEingabe = Console.ReadLine().ToString();
    }
    catch (Exception e) { }
    finally { 
        Console.WriteLine(consoleEingabe);
    }
    
}

