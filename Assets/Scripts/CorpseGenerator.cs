
using System.Collections.Generic;
using UnityEngine;

public static class CorpseGenerator 
{
    static int randomStatMagnitude = 5;
    
    public static GameObject Create()
    {
        string[] name = NameGenerator.Create();
        GameObject corpse = new GameObject($"{name[0]} {name[1]}");
        corpse.AddComponent<Corpse>();

        for (int i = 1; i < (int)BodyPart.Count; i++)
        {
            GameObject part = CreateBodyPart((BodyPart)i);
            part.AddComponent<Attributes>();
            part.transform.parent = corpse.transform;
        }

        AddRandomAttributes(corpse);
        AddJobTrait(corpse);
        AddHobbyTrait(corpse);
        AddDeathTrait(corpse);

        MigrateTraits(corpse);

        return corpse;
    }

    static void MigrateTraits(GameObject corpse)
    {
        Trait[] traits = corpse.GetComponentsInChildren<Trait>();

        for (int i = 0; i < traits.Length; i++)
        {
            traits[i].Up();
        }
    }

    static void AddRandomAttributes(GameObject corpse)
    {
        CorpseBodyPart[] parts = corpse.GetComponentsInChildren<CorpseBodyPart>();
        for (int i = 0; i < parts.Length; i++)
        {
            CorpseBodyPart part = parts[i];
            Attributes attribute = part.GetComponent<Attributes>();
            for (int a = 0; a < (int)Attribute.Count; a++)
            {
                attribute.Change((Attribute)a, Random.Range(-randomStatMagnitude, randomStatMagnitude));
            }

        }
    }

    static void AddJobTrait(GameObject corpse)
    {
        List<System.Type> jobTraits = new List<System.Type>
        {
            typeof(BadBoxer),
            typeof(Dancer),
            typeof(Actor),
            typeof(Physician),
            typeof(Teacher),
            typeof(Farmer),
            typeof(Musician),
            typeof(Pickpocket),
            typeof(Merchant),

        };

        System.Type chosenJob = jobTraits[Random.Range(0, jobTraits.Count)];

        corpse.AddComponent(chosenJob);
    }

    static void AddHobbyTrait(GameObject corpse)
    {
        List<System.Type> hobbyTraits = new List<System.Type>
        {
            typeof(Alcoholic),
            typeof(Jogging),
            typeof(CountingCards),
            typeof(Gardening),
            typeof(Smoking),
            typeof(Devout),
            typeof(Sewing),
            typeof(Rowing),

        };

        System.Type chosenHobby = hobbyTraits[Random.Range(0, hobbyTraits.Count)];

        corpse.AddComponent(chosenHobby);
    }

    static void AddDeathTrait(GameObject corpse)
    {
        List<System.Type> deathTraits = new List<System.Type>
        {
            typeof(Decapitated),
            typeof(CarCrashLegs),
            typeof(Drowned),
            typeof(StomachCannon),
            typeof(Hunger),
            typeof(Diarrhoea),
            typeof(Poison),
            typeof(Radiation),
        };

        System.Type chosenDeath = deathTraits[Random.Range(0, deathTraits.Count)];

        corpse.AddComponent(chosenDeath);
    }

    public static GameObject CreateBodyPart(BodyPart part)
    {
        GameObject partObj = new GameObject(part.ToString());

        CorpseBodyPart cbp = partObj.AddComponent<CorpseBodyPart>();
        cbp.bodyPart = part;

        return partObj;
    }

    public static string GenerateText(GameObject corpse)
    {

        string text = "";

        // Get an intro
        text += $"Here lies {corpse.name}";
        text += "\n";
        text += "\n";

        // Get trait text
        Trait[] traits = corpse.GetComponentsInChildren<Trait>();

        for (int i = 0; i < traits.Length; i++)
        {
            int random = Random.Range(0, 20);
            if (random == 0)
            {
                // 5% chance of faded
                text += "<This part of the tombstone is faded.>";
            }
            else
            {
                text += traits[i].ChooseText();
            }

            if (i != traits.Length - 1)
            {
                text += "\n";
                text += "\n";
            }
        }

        return text;
    }

}
