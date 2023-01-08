using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public static void Clear(Transform parent)
    {
        int childCount = parent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            DestroyImmediate(parent.GetChild(0).gameObject);
        }
    }

    public IEnumerator HideWindow(Transform window)
    {
        window.gameObject.SetActive(false);
        yield return null;
    }

    public IEnumerator ShowWindow(Transform window) 
    {
        window.gameObject.SetActive(true);
        yield return null;
    }

    public static void PrintTableBodyAttributes()
    {
        Debug.Log("Printing Table Body Attributes:");
        Dictionary<Attribute, int> attributeTotals = TableBody.instance.GetAttributeTotals();
        foreach (var attributeTotal in attributeTotals)
        {
            Debug.Log($"{attributeTotal.Key}: {attributeTotal.Value}");
        }

    }

}
