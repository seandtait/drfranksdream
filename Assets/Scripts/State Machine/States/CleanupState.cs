using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanupState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("Clean up!");

        // Destroy the existing body parts on the table
        Functions.Clear(TableBody.instance.transform);
        // Destroy the existing graves
        GraveBodies.instance.Clear();

        GameController.instance.request = null;
        GameController.instance.SelectedBodyPart = BodyPart.None;
        GameController.instance.SelectedGrave = null;

        LabTable.instance.DisableSprites();

        // Hide letter
        FindObjectOfType<Letter>(true).gameObject.SetActive(false);
        // Hide Result window
        FindObjectOfType<Results>(true).gameObject.SetActive(false);
        // Hide Win Screen
        FindObjectOfType<WinView>(true).gameObject.SetActive(false);
        // Hide Lose Screen
        FindObjectOfType<LoseView>(true).gameObject.SetActive(false);
        // Hide Intro Screen
        FindObjectOfType<IntroView>(true).gameObject.SetActive(false);
        // Hide Lab View
        FindObjectOfType<LabView>(true).gameObject.SetActive(false);

        FindObjectOfType<LabView>(true).DoorClickPrompt.SetActive(false);

        GameController.instance.ChangeState<NewRequestState>();
    }

    public override void OnExit()
    {
        Debug.Log("finished cleaning.");


    }

    public override void OnRefresh()
    {
        
    }
}
