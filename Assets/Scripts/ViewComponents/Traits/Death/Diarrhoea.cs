using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diarrhoea : Trait
{

    private void Awake()
    {
        TombstoneText.Add($"{Forename} died of diarrhoea. Their life came to an explosive end.");
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
            //head.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
        }

        GameObject torso = Corpse.GetBodyPart(BodyPart.Torso);
        if (torso)
        {
            //torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
            //torso.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, -5); // Power
        }

        GameObject arms = Corpse.GetBodyPart(BodyPart.Arms);
        if (arms)
        {
            //arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -2); // Beauty
            //arms.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, -5); // Power

        }

        GameObject heart = Corpse.GetBodyPart(BodyPart.Heart);
        if (heart)
        {

        }

        GameObject legs = Corpse.GetBodyPart(BodyPart.Legs);
        if (legs)
        {
            legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)0, -40); // Beauty
            //legs.GetComponent<CorpseBodyPart>().ChangeAttribute((Attribute)3, -5); // Power

        }


    }
}
