using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorpseBodyPart : MonoBehaviour
{
    public BodyPart bodyPart;

    public Attributes GetAttributes()
    {
        return GetComponent<Attributes>();
    }

    public int GetAttributeValue(Attribute attribute)
    {
        Attributes a = GetAttributes();
        return a.Get(attribute);
    }

    public void ChangeAttribute(Attribute attribute, int value)
    {
        Attributes a = GetAttributes();
        a.Change(attribute, value);
    }
}
