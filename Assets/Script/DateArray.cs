static class DateArray
{
    static string[] _days = { "Dimanche", "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi" };
    static string[] _months = { "", "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };

    /// <summary>
    /// Get month (1 = January)
    /// </summary>
    public static string GetMonth(int number)
    {
        return _months[number];
    }

    /// <summary>
    /// Get day (0 = Sunday)
    /// </summary>
    public static string GetDay(int number)
    {
        return _days[number];
    }
}
