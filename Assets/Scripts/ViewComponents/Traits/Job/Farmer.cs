using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmer : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"Growing up on a farm, {Forename} spent their whole life tending to crops and animals alike.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            //brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)4, 30); // Trauma
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)1, -5); // Smarts
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -5); // Beauty
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 5); // Power
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 10); // Power
        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {
            heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, 2); // Beauty
            heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 5); // Power
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 5); // Power
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 5); // Grace
        }


    }
}
