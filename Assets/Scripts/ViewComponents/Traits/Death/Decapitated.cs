using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decapitated : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"A horrific accident involving a horse left {Forename} with nothing above their shoulders.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            DestroyImmediate(brain);
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            DestroyImmediate(head);
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
            heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, 10); // Beauty
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 20); // Power
            legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 40); // Grace
        }


    }
}
