using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corpse : MonoBehaviour
{
    public GameObject GetBodyPart(BodyPart part)
    {
        CorpseBodyPart[] bodyParts = GetBodyParts();

        for (int i = 0; i < bodyParts.Length; i++)
        {
            if (bodyParts[i].bodyPart == part)
            {
                return bodyParts[i].gameObject;
            }
        }

        return null;
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
