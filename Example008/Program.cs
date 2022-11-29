Console.Write("Приветствую Вас, введите Ваше имя :");
string username = Console.ReadLine();
Console.Write("Привет, "); 
Console.WriteLine(username);

Console.Write("Введите расстояние между мальчиками (в метрах) :");
double distanse = Convert.ToInt32(Console.ReadLine());

Console.Write("С какой скоростью идет первый мальчик? :");
double ferst_frend_speed = Convert.ToInt32(Console.ReadLine());

Console.Write("С какой скоростью идет второй мальчик? :");
double second_frend_speed = Convert.ToInt32(Console.ReadLine());

Console.Write("С какой скоростью бежит собака? :");
double dog_speed = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите расстояние встречи мальчиков (от 5 до 20м) :");
double distanse_min = Convert.ToInt32(Console.ReadLine());

int count = 0;

int frend = 2;

while(distanse > distanse_min)
{
    if(frend == 1)
    {
      double time = distanse/(ferst_frend_speed + dog_speed);
      frend = 2;
    }
    else
    {
      double time = distanse/(second_frend_speed + dog_speed);
      frend = 1;    
    }  
    distanse = distanse-(ferst_frend_speed+second_frend_speed)*time;
    count++;
} 

Console.Write("Собака пробежит между мальчиками ");
Console.Write(count);
Console.Write(" раз.");