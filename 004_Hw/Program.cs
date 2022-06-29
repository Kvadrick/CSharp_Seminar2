

int h, a, b;
Console.WriteLine("Введите h");
h = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());

int n = 1; //days
int l = h; //оставшееся расстояние
while (l > a){
     l = h - n * (a - b);
     n++;
}

Console.WriteLine(n);
