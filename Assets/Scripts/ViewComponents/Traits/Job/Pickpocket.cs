using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickpocket : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"{Forename} was a known pickpocketer and will probably not be missed.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)4, 20); // Trauma
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)1, 5); // Smarts
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -10); // Beauty
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
            arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 25); // Grace
        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {
            //heart.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, 5); // Beauty
        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 15); // Power
            legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)2, 15); // Grace
        }


    }
}
