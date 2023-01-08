using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radiation : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"Their close proximity to radiation caused their limbs to grow twice their size before death.");
    }

    public override void OnUp()
    {
        GameObject brain = Corpse.GetBodyPart(BodyPart.Brain);
        if (brain)
        {
            brain.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)1, -30); // Smarts
        }

        GameObject head = Corpse.GetBodyPart(BodyPart.Head);
        if (head)
        {
            //head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            //torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
            torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, -10); // Power
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            //arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
            arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 20); // Power

        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {

        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
            legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, 20); // Power

        }


    }
}
