using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseBodyPartState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("Choose body part!");

        // Prompt the player
        LabTable.instance.ClickBodyPartPrompt.SetActive(true);

        // Enable the buttons
        //LabTable.instance.EnableAll();
        LabTable.instance.EnableUnchosen();
    }

    public override void OnExit()
    {
        Debug.Log("Exiting choose body part");

        // Hide the player prompt
        LabTable.instance.ClickBodyPartPrompt.SetActive(false);

        // Disable the buttons
        LabTable.instance.DisableAll();
    }

    public override void OnRefresh()
    {
        
    }
}
