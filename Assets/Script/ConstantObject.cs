using System.Collections;

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
                tmp = "8h00";
                break;
            case TimeDay.PauseMatin:
                tmp = "10h00";
                break;
            case TimeDay.Midi:
                tmp = "12h30";
                break;
            case TimeDay.PauseAM:
                tmp = "15h00";
                break;
            case TimeDay.ApresMidi:
                tmp = "17h30";
                break;
            case TimeDay.Soir:
                tmp = "20h00";
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
        if (TimeDay != TimeDay.Soir)
        {
            TimeDay++;
        }
        else
        {
            TimeDay = TimeDay.Matin;
        }
    }
}
