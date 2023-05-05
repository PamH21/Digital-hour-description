

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Shkruaj një orë digjitale (në formatin HH:MM): ");
        string input = Console.ReadLine();

        string[] parts = input.Split(':');
        int hours = int.Parse(parts[0]);
        int minutes = int.Parse(parts[1]);

        if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
        {
            Console.WriteLine("Gabim: ora nuk është në formatin e duhur.");
            return;
        }

        string hourWord = Hourtoword(hours);
        string minuteWord = NumberToWord(minutes);

        if (hours <= 12 && minutes <= 30 && minutes >= 0)  Console.WriteLine("Ora eshte {0} e {1} minuta e paradites", hourWord, minuteWord);
        else if (hours >= 12 && minutes <= 30 && minutes >= 0) { Console.WriteLine("Ora eshte {0} e {1} minuta e pasdites", hourWord, minuteWord); }

        else if (hours <= 12 && minutes > 30 && minutes >= 0) Console.WriteLine("Ora eshte " + Hourtoword(hours + 1) + " pa " + NumberToWord(60 - minutes) + "minuta e paradites.");
        else if (hours >= 12 && minutes > 30 && minutes >= 0) Console.WriteLine("Ora eshte " + Hourtoword(hours + 1) + " pa " + NumberToWord(60 - minutes) + " minuta e pasdites.");

    }
    static string Hourtoword(int hours)
    {
        if (hours <= 12&& hours>0) return OnewordsHour[hours];
        else if (hours == 13) return OnewordsHour[1];
        else if (hours == 14) return OnewordsHour[2];
        else if (hours == 15) return OnewordsHour[3];
        else if (hours == 16) return OnewordsHour[4];
        else if (hours == 17) return OnewordsHour[5];
        else if (hours == 18) return OnewordsHour[6];
        else if (hours == 19) return OnewordsHour[7];
        else if (hours == 20) return OnewordsHour[8];
        else if (hours == 21) return OnewordsHour[9];
        else if (hours == 22) return OnewordsHour[10];
        else if (hours == 23) return OnewordsHour[11];
        else if (hours==24) return OnewordsHour[12];
        throw new ArgumentException("Numri duhet të jetë midis 1 dhe 24.");
    } 
    static string NumberToWord(int number)
    {
        if (number < 20 && number>=0) return OnesWords[number];
        if (number < 60 && number >= 0)
        {
            int tens = number / 10;
            int ones = number % 10;

            if (ones == 0)
            {
                return TensWords[tens];
            }
            else
            {
                return TensWords[tens] + " e " + OnesWords[ones];
            }
        }

        throw new ArgumentException("Numri duhet të jetë midis 0 dhe 59.");
    }

    static string[] OnesWords = { "", "një", "dy", "tre", "katër", "pesë", "gjashtë", "shtatë", "tetë", "nëntë", "dhjetë", "njëmbëdhjetë", "dymbëdhjetë", "trembedhjete", "katërmbedhjete", "pesëmbedhjete", "gjashtëmbedhjete", "shtatëmbedhjete", "tetëmbedhjete", "nëntëmbedhjete" };
    static string[] TensWords = { "", "", "njëzet", "tridhjetë", "dyzete", "pesëdhjetë", "gjashtëdhjetë"};
    static string[] OnewordsHour = {"" ,"një", "dy", "tre", "katër", "pesë", "gjashtë", "shtatë", "tetë", "nëntë", "dhjetë", "njëmbëdhjetë", "dymbëdhjetë", "një", "dy", "tre", "katër", "pesë", "gjashtë", "shtatë", "tetë", "nëntë", "dhjetë", "njëmbëdhjetë", "dymbëdhjetë" };
}
 

