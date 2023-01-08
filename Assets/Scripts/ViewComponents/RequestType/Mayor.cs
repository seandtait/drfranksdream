using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mayor : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "Um... The Mayor has had an accident. " +
            "Perhaps you can rustle us up another Mayor just as stupid as the last?";
        
        request.AddCriteria(Attribute.Smarts, 40, false);

        return request;
    }
}
