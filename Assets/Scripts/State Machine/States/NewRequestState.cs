using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRequestState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("(new request)");

        FindObjectOfType<LabView>(true).gameObject.SetActive(true);
        FindObjectOfType<LabView>(true).Door.interactable = true;
        FindObjectOfType<LabView>(true).DoorClickPrompt.SetActive(true);

    }

    public override void OnExit()
    {
        Debug.Log("Exiting new request.");

        // Disable the buttons
        LabTable.instance.DisableAll();

        FindObjectOfType<LabView>(true).Door.interactable = false;
        FindObjectOfType<LabView>(true).DoorClickPrompt.SetActive(false);

    }

    public override void OnRefresh()
    {
        
    }
}
