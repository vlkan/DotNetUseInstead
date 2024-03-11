GetItemsExample();
Console.WriteLine("---------------------");
ShuffleExample();

static void GetItemsExample()
{
    string[] baroqueMusicians =
        [
            "Bach",
            "Vivaldi",
            "Corelli",
            "Purcess",
            "Monteverdi"
        ];

    foreach (var item in baroqueMusicians)
    {
        string[] randomChoices = Random.Shared.GetItems(baroqueMusicians, 2);

        Console.WriteLine(string.Join(",", randomChoices));
    }
}

static void ShuffleExample()
{
    string[] baroqueMusicians =
        [
            "Bach",
            "Vivaldi",
            "Corelli",
            "Purcess",
            "Monteverdi"
        ];

    Random.Shared.Shuffle(baroqueMusicians);
    Console.WriteLine(string.Join("\n", baroqueMusicians));
}