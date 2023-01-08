using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criteria 
{
    public Attribute attribute;
    public int value;
    public bool greaterThan = true;

    public Criteria(Attribute attribute, int value)
    {
        this.attribute = attribute;
        this.value = value;
    }

    public Criteria(Attribute attribute, int value, bool greaterThan) : this(attribute, value)
    {
        this.greaterThan = greaterThan;
    }

    public bool Valid(TableBody tableBody)
    {
        var attrTotals = tableBody.GetAttributeTotals();
        if (!attrTotals.ContainsKey(attribute))
        {
            return false;
        }

        Debug.Log($"Criteria: {attribute} req {value}. Given: {tableBody.GetAttributeTotals()[attribute]}");

        if (greaterThan)
        {
            return tableBody.GetAttributeTotals()[attribute] >= value;
        }

        return tableBody.GetAttributeTotals()[attribute] < value;
    }
}
