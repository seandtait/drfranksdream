using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableBody : MonoBehaviour
{
    public static TableBody instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddPart(GameObject part)
    {
        part.transform.parent = this.transform;
    }

    public bool HasPart(BodyPart part)
    {
        CorpseBodyPart[] bodyParts = GetComponentsInChildren<CorpseBodyPart>();
        for (int i = 0; i < bodyParts.Length; i++)
        {
            if (bodyParts[i].bodyPart == part)
            {
                return true;
            }
        }
        return false;
    }

    public bool HasAllParts()
    {
        List<BodyPart> parts = new List<BodyPart>();
        CorpseBodyPart[] bodyParts = GetComponentsInChildren<CorpseBodyPart>();

        for (int i = 0; i < bodyParts.Length; i++)
        {
            if (!parts.Contains(bodyParts[i].bodyPart))
            {
                parts.Add(bodyParts[i].bodyPart);
            }
        }

        Debug.Log($"{parts.Count} body parts chosen so far.");
        return parts.Count == (int)BodyPart.Count - 1; // - 1 for the BodyPart.None entry
    }

    public Dictionary<Attribute, int> GetAttributeTotals()
    {
        Dictionary<Attribute, int> totalAttributes = new Dictionary<Attribute, int>();

        CorpseBodyPart[] bodyParts = GetBodyParts();
        for (int i = 0; i < bodyParts.Length; i++)
        {
            Attributes attributes = bodyParts[i].GetAttributes();
            for (int a = 0; a < (int)Attribute.Count; a++)
            {
                if (!totalAttributes.ContainsKey((Attribute)a))
                {
                    totalAttributes.Add((Attribute)a, 0);
                }
                totalAttributes[(Attribute)a] += attributes.Get((Attribute)a);
            }
        }

        return totalAttributes;
    }

    public CorpseBodyPart[] GetBodyParts()
    {
        return GetComponentsInChildren<CorpseBodyPart>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
