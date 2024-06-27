// See https://aka.ms/new-console-template for more information

using ReflectionDmeo;

Console.WriteLine("Hello, World!");

var person = new Person{Email = "person@mail.com", Name = "Person"};
var city = new City{Name = "City", Country = "Country"};

ExploreObjectService.ShowMeYouProperties(person);
ExploreObjectService.ShowMeYouProperties(city);
ExploreObjectService.ShowMeYouProperties("Terje");
ExploreObjectService.ShowMeYouProperties(3);