using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* bool faire = true;
             int i = 0;
             while (faire == true)
             {
                 Console.WriteLine("Choisir un exo" + '\n' + "1) Exo1" + '\n' + "2) Exo2");
                 i = Console.Read() - 48;
                 switch (i)
                 {
                     case 1 :
                         Exo1();
                         break;
                     case 2 :
                         Exo2();
                         break;
                     default:
                         Console.WriteLine("Cet Exercice n'existe pas");
                         break;
                 }
             }*/
            //Exo1();
            //Exo2();
            //Exo3();
            Exo7();
        }

        static void Exo1()
        {
            int i = Convert.ToInt32(Console.ReadLine());
            while (i > 0)
            {
                Console.Write(i);
                Console.Write('\n');
                i--;
            }
        }

        static void Exo2()
        {
            Console.WriteLine("Please say ok");
            string s = Console.ReadLine();
            string res = "ok";
            bool vrai = false;
            int i = s.Length;
            for (int j = 0; j < res.Length; j++)
            {
                if (s[j] == res[j])
                {
                    vrai = true;
                }
                else
                {
                    vrai = false;
                }

            }
            if (i > 3 || (vrai == false))
            {
                Console.WriteLine(@"                              .  ....           
                            .o*oo&88&o          
                           .oo*****&88*         
                          o&o*oo;o***88*.       
                          o*o*o*..;**&88&o      
                         .&&o*o**. .o*&*&&o     
                         ;8&oooo**. .o*..o*     
                         ;8&oooo;oo. .o*. .     
                         ;8&oooo**oo...oo       
                         ;8&oo;*#8#&8*;o;       
                         ;8&o;oo..&#@&o&;       
                         ;88*ooo..##&8o*        
                         ;88&*oo;.8@#ooo.       
                oooo.    ;8#8&*o;.;*&oo*o.      
               o*oo**.   ;88#88*;o;;;;oo*.      
              .*o;;o**   ;88888o;;;ooooo.       
         ;oooo**oooooo.  ;##88*oo****;;.        
       .*&####8ooooo;o*. ;##88&**...            
       ;&&8888&oooooo;*o;o##8*&&o               
       *&88888*oooooooo**o8##o*&.               
      *&888&;o*oooo;;;;o*;*##*o*.               
     o&88* .o&&*ooooooooooo&#8o*.               
    .&888.;*8&&*oo*&&&&*ooo*88o*.               
    ;88#o.*8*;&**&&&&&*ooooo*&oo.               
    &88&;o&&;;&&&&&*ooo;ooo;o&*;                
   .&&*..*8& ;&&&&*ooooooooo;o**.               
   **&o.o*8;  o&&&ooo*oooo*oo;o**.              
   *oo.;*88.  ;&&&o;*&*oooo&*ooooo.             
   o;*.*88&.   *&*oo**o    ;&**o;o;             
    ;;;8&&o    *&oo***;    .**&o;o;             
    ;;o8*&o    **;o***     .***oo*;             
    ;;o&;o.  .o**o***;     o&&ooo*.             
    ;;oo     *oo*****      ***oo*o              
    ;;o.    .*oo****.     ****&*o               
    ;**      o*oo*;.     ;&**&;;                
     o*                   o**.                  
     ;*                                         
");
            }
        }
        static void Exo3()
        {
            string reponse;
            do
            {
                Console.WriteLine("Please say ok" + '\n' + "your answer :");
                reponse = Console.ReadLine();
            } while (reponse != "ok");
        }
        static void Exo4()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("test with while");
            }
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("test with");
            }
        }

        static void Exo5()
        {
            string res = Console.ReadLine();
            for (int i = 1; i < 44; i++)
            {
                Console.WriteLine(Convert.ToString(i) + res);

            }
        }

        static void Exo6()
        {
            int[,] tab = new int[,] {{1,1,1,1},
                                      {2,2,2,2},
                                      {3,3,3,3},
                                      {4,4,4,4}};
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (j != 0)
                    {
                        Console.Write("| " + Convert.ToString(tab[i, j]) + " |");
                    }
                    else
                    {
                        Console.Write('\n' + "| " + Convert.ToString(tab[i, j]) + " |");
                    }
                }
            }
            Console.WriteLine('\n');
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (j != 0)
                    {
                        Console.Write("| " + Convert.ToString(tab[j, i]) + " |");
                    }
                    else
                    {
                        Console.Write('\n' + "| " + Convert.ToString(tab[j, i]) + " |");
                    }
                }
            }
            Console.WriteLine('\n');
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (j != 0)
                    {
                        if (i == j)
                        {
                            Console.Write("| 42 |");
                        }
                        else
                        {
                            Console.Write("|  " + Convert.ToString(tab[i, j]) + " |");
                        }
                    }
                    else
                    {
                        if (i == j)
                        {
                            Console.Write("| 42 |");
                        }
                        else
                        {
                            Console.Write('\n' + "|  " + Convert.ToString(tab[i, j]) + " |");
                        }
                    }

                }
            }
            Console.WriteLine();
        }

        static void Exo7()
        {
            int acc;
            int res;
            for (int i = 1; i <= 10; i++)
            {
                acc = 0;
                res = i;
                for (int j = 1; j <= i; j++)
                {
                    if (j <= i - 1)
                    {
                        Console.Write(Convert.ToString(j) + "+");
                        acc = acc + j;
                    }
                    else
                    {
                        Console.Write(Convert.ToString(j));
                        acc = acc + j;
                    }
                }
                Console.WriteLine(" = " + Convert.ToString(acc));
            }
        }


    }

}

