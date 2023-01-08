using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomachCannon : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"{Forename} was shot in the stomach by a cannon at point blank range. This sadly led to their death.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            //brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)1, -5); // Smarts
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            //head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -10); // Beauty
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            DestroyImmediate(torso);
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            //arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {
            DestroyImmediate(heart);
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
        }


    }
}
