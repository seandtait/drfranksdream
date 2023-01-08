using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpouseFinder : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "Help! I told my parents I was married when I'm not. " +
            "Make me a spouse... and make them good looking.";
        
        request.AddCriteria(Attribute.Beauty, 70);

        return request;
    }
}
