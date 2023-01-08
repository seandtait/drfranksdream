using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Trait : MonoBehaviour
{
    public Corpse Corpse { get { return GetComponent<Corpse>(); } }
    public string Forename { get { return Corpse.name.Split(" ")[0]; } }

    public bool active = false;

    public virtual void Up()
    {
        if (!active)
        {
            active = true;
            OnUp();
        }
    }

    public abstract void OnUp();

    public List<string> TombstoneText = new List<string>();

    public string ChooseText()
    {
        return TombstoneText[Random.Range(0, TombstoneText.Count)];
    }

}
