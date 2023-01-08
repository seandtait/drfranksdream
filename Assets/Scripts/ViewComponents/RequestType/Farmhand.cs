using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Farmhand : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "I am looking for someone strong and able bodied to work on my farm. " +
            "They can't be too ugly, though! Don't want them scaring away the horses!";
        
        request.AddCriteria(Attribute.Power, 70);
        request.AddCriteria(Attribute.Beauty, 50);

        return request;
    }
}
