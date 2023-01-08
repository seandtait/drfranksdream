using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    Dictionary<Attribute, int> values;

    public int DefaultValue = 5;

    public int Get(Attribute attribute)
    {
        if (values.ContainsKey(attribute))
        {
            return values[attribute];
        }
        return 0;
    }

    public bool HasAttribute(Attribute attribute)
    {
        return values.ContainsKey(attribute);
    }

    public Attributes()
    {
        values = new Dictionary<Attribute, int>();

        for (int i = 0; i < (int)Attribute.Count; i++)
        {
            values.Add((Attribute)i, DefaultValue);
        }
    }

    public void Change(Attribute attribute, int value)
    {
        values[attribute] += value;
    }

}
