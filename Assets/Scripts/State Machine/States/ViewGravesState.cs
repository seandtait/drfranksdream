using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewGravesState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("(view graves)");

        // Show graves window
        FindObjectOfType<GraveView>(true).gameObject.SetActive(true);

        // Generate corpses
        GraveBodies.instance.GenerateCorpses();

        GameController.instance.ChangeState<ChooseBodyPartState>();
    }

    public override void OnExit()
    {
        Debug.Log("Exiting new request.");

        
    }

    public override void OnRefresh()
    {
        
    }
}
