using NETOOGenerics;

//DateTime date = DateTime.Now;

//User<DateTime> user = new User<DateTime>(date);

//Console.WriteLine(user.isMyId(date));

List<string> list = new List<string> { "Bjr", "Slt", "RELOO"};

List<Voiture> voitures = new List<Voiture>
{
    new Voiture("Blue"),
    new Voiture("Red"),
    new Voiture("Purple"),
    new Voiture("Green")
};

Dictionary<string, Voiture> voitureDictionary = new Dictionary<string, Voiture>
{
    {"Purple" , new Voiture("Purple")},
    {"Red" , new Voiture("Red")},
    {"Blue" , new Voiture("Blue")},
    {"Green" , new Voiture("Green")}
};

Voiture? voit = voitureDictionary.DicoFirst(x => x == "Yellow");

if (voit is not null)
{
    Console.WriteLine(voit.Color);
}

Voiture selectedVoiture = voitures.NewFirst( v => v.IsColor("Purple"));

string maValue = list.First(x => x == "Slt");

Console.WriteLine(selectedVoiture.Color);

