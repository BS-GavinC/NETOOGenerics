using NETOOGenerics;


Console.WriteLine(Exo.Add(12, 27.9));
//int a = 12;
//int b = 27;
//Exo.SwapValues(ref a, ref b);

//Console.WriteLine(a);
//Console.WriteLine(b);

//DateTime date = DateTime.Now;

//User<DateTime> user = new User<DateTime>(date);

//Console.WriteLine(user.isMyId(date));

//List<int> list = new List<int> { 1, 2, 3};

//List<Voiture> voitures = new List<Voiture>
//{
//    new Voiture("Blue"),
//    new Voiture("Red"),
//    new Voiture("Purple"),
//    new Voiture("Green")
//};


//Voiture selectedVoiture = voitures.NewFirst(v => v.IsColor("Purple"));

//int selectString = list.NewFirst(x => x == 2);

//string maValue = list.First(x => x == "Slt");

//Console.WriteLine(selectedVoiture.Color);

//Dictionary<string, Voiture> voitureDictionary = new Dictionary<string, Voiture>
//{
//    {"Purple" , new Voiture("Purple")},
//    {"Red" , new Voiture("Red")},
//    {"Blue" , new Voiture("Blue")},
//    {"Green" , new Voiture("Green")}
//};

//Voiture? voit = voitureDictionary.DicoFirst(x => x == "Yellow");

//if (voit is not null)
//{
//    Console.WriteLine(voit.Color);
//}