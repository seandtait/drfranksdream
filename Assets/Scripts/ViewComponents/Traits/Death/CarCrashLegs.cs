using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrashLegs : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"The car crash crushed {Forename}'s lower body, leading to their demise.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            //DestroyImmediate(brain);
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            //DestroyImmediate(head);
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            //torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 5); // Power
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            //arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 10); // Power
        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {
            //heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, 10); // Beauty
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            DestroyImmediate(legs);
        }


    }
}
