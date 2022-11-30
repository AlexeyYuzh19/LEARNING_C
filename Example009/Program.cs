// Программа с собачкой - алгоритм взят из курса "Начни программировать" - онлан-практикум "Напиши свою первую программу".
Console.WriteLine("Hello, World!");

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

int dog_counter = 0;

int dog_direktion = 1;

while(distanse > distanse_min)
{
    double speed = 0;

    if(dog_direktion == 1)
    {
      speed = ferst_frend_speed + dog_speed;
      dog_direktion = 2;
    }
    else
    {
      speed = second_frend_speed + dog_speed;
      dog_direktion = 1;          
    }  
    
    double time_to_meet = distanse / speed;
    distanse = distanse - (ferst_frend_speed + second_frend_speed) * time_to_meet; 
      
    Console.WriteLine(distanse);
    
    dog_counter++;
} 

Console.Write("Собака пробежит между мальчиками ");
Console.Write(dog_counter);
Console.Write(" раз.");
