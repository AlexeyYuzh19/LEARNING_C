Console.Write("Приветствую Вас, введите Ваше имя :");
string username = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Green;

if(username.ToLower() == "маша")
{
      Console.WriteLine("Ооо... это же сама МАРИЯ ВЕЛИКАЯ! Низкий Вам поклон и глубокая признательность за уделенное внимание!\n");
}
else
{
      Console.Write("Привет, "); 
      Console.WriteLine(username);
}

Console.Write("Введите целое число от 99 до 99999 :");
int namber = Convert.ToInt32(Console.ReadLine());

Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa=45, ya=1,
    xb=1, yb=30,
    xc=90, yc=30;

Console.SetCursorPosition(xa,ya);
Console.WriteLine("*");

Console.SetCursorPosition(xb,yb);
Console.WriteLine("*");

Console.SetCursorPosition(xc,yc);
Console.WriteLine("*");

int x=xa, y=xb;

int count=0;

Console.ForegroundColor = ConsoleColor.Red;

while(count<namber)
{
     int what=new Random().Next(0,3);    //   [0;3)  0  1  2
     if(what==0)
     {
        x=(x+xa)/2;
        y=(y+ya)/2;
     }

     if(what==1)
     {
        x=(x+xb)/2;
        y=(y+yb)/2; 
     }

     if(what==2)
     {
        x = (x+xc)/2;
        y = (y+yc)/2;
     }
     
     Console.SetCursorPosition(x,y);
     Console.WriteLine("*");
     count++;
}

Console.ForegroundColor = ConsoleColor.Blue;

int a=35, b=31 ;
Console.SetCursorPosition(a,b);
Console.WriteLine("*");

Console.Write(" ЭТА ЗАМЕЧАТЕЛЬНАЯ   КАРТИНКА  ДЛЯ  ВАС \n БЛАГОДАРЮ  ЗА  ВНИМАНИЕ !\n\n");

Console.ResetColor();