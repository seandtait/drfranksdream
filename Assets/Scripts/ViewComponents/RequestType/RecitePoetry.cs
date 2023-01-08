using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecitePoetry : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "Good eve, my fellow. " +
            "I require an intellectual companion that will recite poetry with myself.";
        
        request.AddCriteria(Attribute.Smarts, 70);

        return request;
    }
}
