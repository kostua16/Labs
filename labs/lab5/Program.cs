/*
 * Created by SharpDevelop.
 * User: Владелец
 * Date: 30.05.2013
 * Time: 20:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
namespace lab5
{
	class lab5
    {
        static int ch_hud_lit = 0;
        static int ch_ist_lit = 0;
        static int ch_pc = 0;
        static int ch_math = 0;
        static int ch_est_sci = 0;
        static int ch_eco = 0;/////////// Чакона ///////////
        static int m_hud_lit = 0;
        static int m_ist_lit = 0;
        static int m_eco = 0;//////////// Метида ///////////
        static int s_pc = 0;
        static int s_math = 0;
        static int s_est_sci = 0;
        static int s_eco;//////////// Стрела ///////////
		static int finalChaGrade = 0;
		static int finalMeGrade = 0;//finals
		static int finalStGrade = 0;
        static int response;
		static string MoreGradesToCalculate;
    public static void Main(string[] args)
    {
        response = whatkindofmag();
        MoreGradesToCalculate="YES";
        while (MoreGradesToCalculate == "YES")
        {
            switch (response)
            {
                case 1:
            		calculatechakona();displaysale(ch_hud_lit, ch_ist_lit, ch_pc, ch_math, ch_est_sci, ch_eco,finalChaGrade);break;
                case 2:
                    calculatemetida();displaysale(m_hud_lit, m_ist_lit, m_eco,finalMeGrade);break;
                case 3:
                    calculatestrela();displaysale(s_pc, s_math, s_est_sci, s_eco,finalStGrade);break;
                default:
                    MessageBox.Show(response + " - Некорректный номер магазина!");break;
            }
            Console.Write("Хотите продолжить?");
            MoreGradesToCalculate = Console.ReadLine();MoreGradesToCalculate = MoreGradesToCalculate.ToUpper();
        }
    }
           public static int whatkindofmag()
           {
               Console.WriteLine("Выберите один из магазинов");
               Console.Write("1=Математический" + "\n" + 
                          	 "2=Экономический" + "\n" +
                          	 "3=Электротехнический"+"\n"+":");
               string resp=Console.ReadLine();
               int r=1;
               if(int.TryParse(resp,out r)){return r;}
               else{Console.WriteLine("Неверный выбор!");Console.ReadKey(true);Environment.Exit(0);return 0;}
              }
            public static void calculatechakona()
            {
                    Console.WriteLine("Художественная литература, продано:");ch_hud_lit=int.Parse(Console.ReadLine()); finalChaGrade += ch_hud_lit;
                    Console.WriteLine("Историческая литература, продано:");ch_ist_lit=int.Parse(Console.ReadLine()); finalChaGrade += ch_ist_lit;
                    Console.WriteLine("Компьютеры, продано:");ch_pc=int.Parse(Console.ReadLine()); finalChaGrade +=ch_pc;
                    Console.WriteLine("Математика, продано:");ch_math=int.Parse(Console.ReadLine()); finalChaGrade += ch_math;
                    Console.WriteLine("Естественные науки, продано:");ch_est_sci=int.Parse(Console.ReadLine()); finalChaGrade += ch_est_sci;
                    Console.WriteLine("Экономика, продано:");ch_eco=int.Parse(Console.ReadLine()); finalChaGrade += ch_eco;
            }
            public static void calculatemetida()
            {
                    Console.WriteLine("Художественная литература, продано:");m_hud_lit=int.Parse(Console.ReadLine()); finalMeGrade += m_hud_lit;
                    Console.WriteLine("Историческая литература, продано:");m_ist_lit=int.Parse(Console.ReadLine()); finalMeGrade += m_ist_lit;
                    Console.WriteLine("Экономика, продано:");m_eco=int.Parse(Console.ReadLine()); finalMeGrade += m_eco;
            }
            public static void calculatestrela()
            {
                    Console.WriteLine("Компьютеры, продано:");s_pc=int.Parse(Console.ReadLine()); finalStGrade += s_pc;
                    Console.WriteLine("Математика, продано:");s_math=int.Parse(Console.ReadLine()); finalStGrade += s_math;
                    Console.WriteLine("Естественные науки, продано:");s_est_sci=int.Parse(Console.ReadLine()); finalStGrade += s_est_sci;
                    Console.WriteLine("Экономика, продано:");s_eco=int.Parse(Console.ReadLine()); finalStGrade += s_eco;
            }  
            public static void displaysale(int ch_hud_lit,int ch_ist_lit,int ch_pc,int ch_math,int est_sci,int ch_eco,int finalChGrade)
			{
				MessageBox.Show
					(	"Продано книг в магазине ЧАКОНА \n\n" +
						"Художественная литература» " + ch_hud_lit + "\n" +
						"Историческая Литература» " + ch_ist_lit + "\n" +
						"Компьютеры» " + ch_pc + "\n" +
						"Математика» " + ch_math + "\n" +
						"Естественные науки» " + ch_est_sci + "\n" +
						"Экономика» " + ch_eco + "\n" +
						"ОБЩЕЕ КОЛИЧЕСТВО:" + finalChGrade
					);
			}
			public static void displaysale(int m_hud_lit,int m_ist_lit,int m_eco,int finalMeGrade)
			{
				MessageBox.Show
					(
						"Продано книг в магазине МЕТИДА \n\n" +
						"Художественная литература» " + m_hud_lit + "\n" +
						"Историческая литература» " + m_ist_lit + "\n" +
						"Экономика» " + m_eco + "\n" +
						"ОБЩЕЕ КОЛИЧЕСТВО:" + finalMeGrade
					);
			}
			public static void displaysale(int s_pc,int s_math,int s_est_sci,int s_eco,int finalStGrade)
			{
				MessageBox.Show
					(
						"Продано книг в магазине СТРЕЛА \n\n" +
						"Компьютеры» " + s_pc + "\n" +
						"Математика» " + s_math + "\n" +
						"Естественные науки» " + s_est_sci + "\n" +
						"Экономика» " + s_eco + "\n" +
						"ОБЩЕЕ КОЛИЧЕСТВО:" + finalStGrade
					);
		 	}

        }
}