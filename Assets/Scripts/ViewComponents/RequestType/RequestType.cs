using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RequestType 
{
    public Request Create()
    {
        Request request = new Request();
        return OnCreate(request);
    }

    public abstract Request OnCreate(Request request);

}
