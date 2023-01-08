using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcoholic : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"{Forename} wrestled with the alcohol demon all of their life but always tried their best.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)4, 10); // Trauma
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)1, -20); // Smarts
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -5); // Beauty
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            //torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 10); // Power
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            //arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 20); // Power
        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {
            heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, -15); // Power
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 15); // Power
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 5); // Grace
        }


    }
}
