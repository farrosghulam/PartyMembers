string[] party = { "John", "Alex", "Padil", "Joni",  };

//Display all party members using a for loop
for (int i = 0; i < party.Length; i++)
{
    Console.WriteLine($"Member {i + 1}: {party[i]}");
}

//Change the third party member
party[2] = "Rizal";
Console.WriteLine($"\nUpdated Member 3: {party[2]}");