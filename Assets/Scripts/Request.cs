using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request 
{
    public int baseReward = 0;
    public string LetterText = "";
    public List<Criteria> criteria = new List<Criteria>();

    public int GetReward()
    {
        int reward = 0;

        for (int i = 0; i < criteria.Count; i++)
        {
            Attribute attribute = criteria[i].attribute;
            bool greaterThan = criteria[i].greaterThan;
            int criteriaValue = criteria[i].value;

            int actualAttributeValue = 0;
            if (TableBody.instance.GetAttributeTotals().ContainsKey(attribute))
            {
                actualAttributeValue = TableBody.instance.GetAttributeTotals()[attribute];
            }

            if (greaterThan)
            {
                reward += actualAttributeValue - criteriaValue;
            } else
            {
                reward += actualAttributeValue + criteriaValue;
            }
        }
        
        return reward;
    }

    public bool IsSuccess(TableBody tableBody)
    {
        for (int i = 0; i < criteria.Count; i++)
        {
            if (criteria[i].Valid(tableBody) == false)
            {
                return false;
            }
        }
        return true;
    }

    public void AddCriteria(Attribute attribute, int value)
    {
        criteria.Add(new Criteria(attribute, value));
    }

    public void AddCriteria(Attribute attribute, int value, bool greaterThan)
    {
        criteria.Add(new Criteria(attribute, value, greaterThan));
    }

}
