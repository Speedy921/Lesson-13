using Lesson_13;

Console.WriteLine("*******Fun with Automatic Prop*******");

Car c = new Car();
c.PetName = "Frank";
c.Speed = 55;
c.Color = "Red";
Console.WriteLine("U car is named {0}? That's odd...", c.PetName);
c.DisplayStats();
Console.ReadLine();

//поместить автомобиль в гараж 
Garage g = new Garage();
g.MyAuto = c;
//вывести количество автомобилей в гараже
Console.WriteLine("Number of Cars in garage: {0}", g.NumberofCars);
//вывести название автомобиля
Console.WriteLine("U cars is named: {0}", g.MyAuto.PetName);