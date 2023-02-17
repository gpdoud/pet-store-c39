
using pet_store_c39;

IPet[] pets = new IPet[] {
    new Dog() { Name = "Fido" },
    new Cat() { Name = "Felix" },
    new Duck() { Name = "Donald" },
    new Cow() { Name = "Daisy" }
};

foreach(var pet in pets) {
    Console.WriteLine($"{pet.Name} says {pet.Speak()}");
}