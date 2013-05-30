/*
 * Created by SharpDevelop.
 * User: Владелец
 * Date: 30.05.2013
 * Time: 19:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace lab4
{
	class Program
	{
		public static void Main(string[] args)
        {
            int point_first = 0;int point_second = 0;
            int i = 1;bool exit=false;
            Console.WriteLine("Название Первой Команды »");string first_team = Console.ReadLine();
            Console.WriteLine("Название Второй Команды »");string second_team = Console.ReadLine();
            while (exit==false)
            {
                Console.WriteLine("Какая команда сделала попадание №" + i + " ?");
                string response = Console.ReadLine();
                switch (response) {
                	case "1":
                		Console.WriteLine("Cколько очков получила за заброс мяча?");
                    	point_first += int.Parse(Console.ReadLine());
                    	ShowSchet(first_team,second_team,point_first,point_second);
                		break;
                	case "2":
                		Console.WriteLine("Cколько очков получила за заброс мяча?");
                    	point_second += int.Parse(Console.ReadLine());
                    	ShowSchet(first_team,second_team,point_first,point_second);
                		break;
                	default:
                		Console.WriteLine("Такой команды нет!");
                		break;
                }
                Console.WriteLine("Матч закончился?");
                string end = Console.ReadLine();
                i++;
                if (end == "да" || end == "1" || end == "yes" ||
                    end == "da" || end == "y" || end == "д" || 
                    end=="d") exit=true;
            }
             
            if (point_first > point_second)
                Console.WriteLine("Матч окончился победой команды " + first_team);
            if (point_first < point_second)
                Console.WriteLine("Матч окончился победой команды " + second_team);
            if (point_first == point_second)
                Console.WriteLine("Матч окончился ничьей!!");
            Console.ReadKey(true);
        }
		public static void ShowSchet(string name1,string name2,int res1,int res2)
		{
			Console.WriteLine("Текущий счёт »»");
            Console.WriteLine(name1 + " : " + res1);
            Console.WriteLine("_____________________");
            Console.WriteLine(name2 + " : " + res2);
		}
	}
}