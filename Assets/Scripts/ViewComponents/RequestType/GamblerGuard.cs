using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamblerGuard : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "I like to gamble but I don't always win. " +
            "I need a bodyguard!";
        
        request.AddCriteria(Attribute.Power, 80);

        return request;
    }
}
