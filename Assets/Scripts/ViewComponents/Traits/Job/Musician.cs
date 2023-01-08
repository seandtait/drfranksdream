using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musician : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"{Forename} spent every day playing different instruments to make some coin.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)4, 30); // Trauma
            //brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)1, -10); // Smarts
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, 10); // Beauty
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 5); // Power
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 20); // Grace
        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {
            //heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, 10); // Beauty
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 20); // Power
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 40); // Grace
        }


    }
}
