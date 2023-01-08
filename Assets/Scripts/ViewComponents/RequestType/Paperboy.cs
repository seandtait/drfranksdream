using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paperboy : RequestType
{
    public override Request OnCreate(Request request)
    {
        request.baseReward = 100;
        request.LetterText = "My last employee died running away from a dog. " +
            "I need someone nimble to deliver these newspapers!";
        
        request.AddCriteria(Attribute.Grace, 60);

        return request;
    }
}
