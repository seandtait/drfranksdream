using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePartToTableState : State
{
    
    public override void OnEnter()
    {
        int graveIndex = GameController.instance.SelectedGrave.GetComponent<Grave>().index;
        Corpse corpse = GraveBodies.instance.graves[graveIndex].GetComponentInChildren<Corpse>();
        GameObject selectedCorpse = corpse.gameObject;

        Debug.Log($"Moving {selectedCorpse.name}'s {GameController.instance.SelectedBodyPart} to table");
        GameObject bodyPart = corpse.GetBodyPart(GameController.instance.SelectedBodyPart);

        if (bodyPart != null)
        {
            TableBody.instance.AddPart(bodyPart);
        }

        LabTable.instance.EnableSprites();

        // Debug each attribute
        Functions.PrintTableBodyAttributes();

        // Is there a full body?
        if (TableBody.instance.HasAllParts())
        {
            GameController.instance.ChangeState<ViewResultState>();
        } else
        {
            GameController.instance.ChangeState<ChooseBodyPartState>();
        }
    }

    public override void OnExit()
    {
        Debug.Log("Exiting MovePartToTable.");


    }

    public override void OnRefresh()
    {
        
    }
}
