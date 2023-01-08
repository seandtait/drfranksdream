using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballerina : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "The ballerina for tonight's show broke her leg! " +
            "I need a replacement. The show must go on!";
        
        request.AddCriteria(Attribute.Grace, 70);

        return request;
    }
}
