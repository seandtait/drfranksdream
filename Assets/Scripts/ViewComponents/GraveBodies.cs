using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraveBodies : MonoBehaviour
{
    public static GraveBodies instance;

    private void Awake()
    {
        instance = this;
    }

    public List<Transform> graves;

    public void AddCorpse(int graveIndex, GameObject corpse)
    {
        corpse.transform.SetParent(graves[graveIndex].transform);
    }

    public void GenerateCorpses()
    {
        // Create 3 new corpses
        for (int i = 0; i < 3; i++)
        {
            GameObject corpse = CorpseGenerator.Create();
            AddCorpse(i, corpse);
        }

        GraveUI.instance.SetGraveText();
    }

    public void Clear()
    {
        Functions.Clear(graves[0]);
        Functions.Clear(graves[1]);
        Functions.Clear(graves[2]);
    }


}
