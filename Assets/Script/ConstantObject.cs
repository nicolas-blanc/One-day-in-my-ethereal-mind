using System;
using System.Collections;


public enum TimeDay { Matin = 0, Matin2, PauseMatin, matin3, Midi, ApresMidi, PauseAM, ApresMidi3, Soiree, Soiree2, Nuit, Nuit2, TimeToSleep };


public static class ConstantObject {

    private static bool init = false;

    private static TimeDay timeDay;
    private static TimeDay TimeDay
    {
        get
        {
            return timeDay;
        }

        set
        {
            timeDay = value;
        }
    }


    private static ArrayList book;
    private static ArrayList Book
    {
        get
        {
            return book;
        }

        set
        {
            book = value;
        }
    }
    
    public static void initilisation()
    {
        TimeDay = TimeDay.Matin;
        Book = new ArrayList();

        Book.Add("8h00 - Cours de gestion");
        Book.Add("10h30 - Retrouver Annette au parc");
        Book.Add("12h00 - Mangeeeeeer !! Il y a des frites au menu");
        Book.Add("13h30 - Cours d'anglais, les deux heures les plus longues de ma vie");
        Book.Add("15h30 - Passage a la librairie, je dois rendre le livre");
        Book.Add("16h00 - Rendez-vous chez le doc");
        Book.Add("17h00 - Il faut que je passe a la boutique, Deborah aura surement une trouvaille pour moi");
        Book.Add("21h00 - Ce soir, je vais au theatre");

        init = true;
    }

    public static bool getInit()
    {
        return init;
    }

    public static string getLine(int l)
    {
        return (string)Book[l];
    }

    public static int getNumberOfPage()
    {
        return (Book.Count / 7) + 1;
    }

    public static int getNumberLine()
    {
        return Book.Count;
    }

    public static string getTimeToString()
    {
        string tmp;
        switch (TimeDay)
        {
            case TimeDay.Matin:
                tmp = "7h30";
                break;
            case TimeDay.Matin2:
                tmp = "9h00";
                break;
            case TimeDay.PauseMatin:
                tmp = "10h00";
                break;
            case TimeDay.matin3:
                tmp = "11h00";
                break;
            case TimeDay.Midi:
                tmp = "12h30";
                break;
            case TimeDay.ApresMidi:
                tmp = "14h00";
                break;
            case TimeDay.PauseAM:
                tmp = "15h00";
                break;
            case TimeDay.ApresMidi3:
                tmp = "16h00";
                break;
            case TimeDay.Soiree:
                tmp = "17h30";
                break;
            case TimeDay.Soiree2:
                tmp = "18h30";
                break;
            case TimeDay.Nuit:
                tmp = "20h30";
                break;
            case TimeDay.Nuit2:
                tmp = "21h30";
                break;
            case TimeDay.TimeToSleep:
                tmp = "22h00";
                break;
            default:
                tmp = "";
                break;
        }

        return tmp;
    }

    public static TimeDay getTime()
    {
        return TimeDay;
    }

    public static void nextTimeDay()
    {
        if (TimeDay != TimeDay.TimeToSleep)
        {
            TimeDay++;
        }
        else
        {
            TimeDay = TimeDay.TimeToSleep;
        }
    }
}
