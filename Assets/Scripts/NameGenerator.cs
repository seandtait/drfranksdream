using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NameGenerator 
{
    public static string[] Create()
    {
        return new string[2] { GetFore(), GetSur() };
    }

    public static string GetFore()
    {
        List<string> forenames = new List<string>()
        {
            "Sean",
            "John",
            "Paul",
            "Dave",
            "David",
            "Davey",
            "Brian",
            "Lisa",
            "Audrey",
            "Sharlene",
            "Roger",
            "Floyd",
            "Mary",
            "Charlotte",
            "Oliver",
            "Declan",
            "Theodore",
            "Jasper",
            "Silas",
            "Aurora",
            "Violet",
            "Hazel",
            "Luna",

        };

        return forenames[Random.Range(0, forenames.Count)];
    }

    public static string GetSur()
    {
        List<string> surnames = new List<string>()
        {
            "Tait",
            "Davis",
            "Montgomery",
            "Andrews",
            "Angus",
            "Lion",
            "Damon",
            "Wrigley",
            "Blackburn",
            "Jones",
            "Aiton",
            "Ainsley",
            "Allard",
            "Beckham",
            "Baffin",
            "Beasley",
            "Bellamy",
            "Daine",
            "Dalgliesh",
            "Dayton",
            "Dumphries",
            "Ingrahm",
            "Irons",
            "Matthews",
            "Maine",
            "McKay",
            "Morey",
            "Minnow",
            "Ted",
            "Tarne",
            "Tully",

        };

        return surnames[Random.Range(0, surnames.Count)];
    }


}
