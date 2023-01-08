using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgainState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("Try again tomorrow");

        // Roll
        int riskRoll = Random.Range(0, 100);

        if (riskRoll < GameController.instance.CurrentRisk)
        {
            // CAUGHT
            GameController.instance.ChangeState<ViewResultState>();
        } else
        {
            // Safe
            // Destroy the existing graves
            GraveBodies.instance.Clear();

            GameController.instance.SelectedBodyPart = BodyPart.None;
            GameController.instance.SelectedGrave = null;

            GraveBodies.instance.GenerateCorpses();

            GameController.instance.ChangeState<ChooseBodyPartState>();
        }



        
    }

    public override void OnExit()
    {
        Debug.Log("Finished try again tomorrow.");


    }

    public override void OnRefresh()
    {
        
    }
}
