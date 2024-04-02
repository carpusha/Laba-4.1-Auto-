using ConsoleApp27;

Wheel w = new Wheel(17);
Wheel newWheel = new Wheel(18);
Engine en = new Engine(150);
Engine en2 = new Engine(200);
Auto toyota = new Auto("Toyota", w, en);
Auto Ford = new Auto("Ford", w, en);
Console.WriteLine(toyota.ToString());
Console.WriteLine(toyota.GetHashCode());
Console.WriteLine(toyota.Equals(Ford));
Console.WriteLine("------------");
Console.WriteLine(en2.Equals(en));
Console.WriteLine(en.GetHashCode());
Console.WriteLine(en.ToString());
Console.WriteLine("-------------");
Console.WriteLine(w.GetHashCode());
Console.WriteLine(w.ToString());
Console.WriteLine(w.Equals(newWheel));
Console.WriteLine("----------------");
toyota.Go();
toyota.Refuel();
toyota.ReplaceWheel(newWheel);

