using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class RequestGenerator 
{
    public static Request Create()
    {
        List<RequestType> requestTypes = new List<RequestType>()
        {
            new Farmhand(),
            new SpouseFinder(),
            new GamblerGuard(),
            new Ballerina(),
            new Mayor(),
            new RecitePoetry(),
            new Paperboy(),


        };

        RequestType requestType = requestTypes[Random.Range(0, requestTypes.Count)];
        return requestType.Create();
    }
}
