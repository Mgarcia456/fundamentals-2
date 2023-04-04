
    // Create integer array
    int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

    // Create string array
    string[] names = {"Tim", "Martin", "Nikki", "Sara"};

    // Create boolean array
    bool[] bools = new bool[10];
    for (int i = 0; i < bools.Length; i++) {
      if (i % 2 == 0) {
        bools[i] = true;
      } else {
        bools[i] = false;
      }
    }

    // Create List of ice cream flavors
    List<string> flavors = new List<string>{"Chocolate", "Vanilla", "Strawberry", "Mint", "Cookies and Cream"};

    // Output length of List
    Console.WriteLine("Length of flavors list: " + flavors.Count);

    // Output third flavor in List
    Console.WriteLine("Third flavor in list: " + flavors[2]);

    // Remove third flavor in List
    flavors.RemoveAt(2);

    // Output length of List again
    Console.WriteLine("New length of flavors list: " + flavors.Count);

    // Create dictionary of user preferences
    Dictionary<string, string> userPreferences = new Dictionary<string, string>();

    // Assign random flavor to each user
    Random rand = new Random();
    foreach (string name in names) {
      string flavor = flavors[rand.Next(flavors.Count)];
      userPreferences.Add(name, flavor);
    }

    // Loop through dictionary and print user preferences
    foreach (KeyValuePair<string, string> pair in userPreferences) {
      Console.WriteLine(pair.Key + " likes " + pair.Value + " ice cream.");
    }
  

