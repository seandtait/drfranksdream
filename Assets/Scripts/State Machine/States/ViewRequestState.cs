using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRequestState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("(view request)");

        // Generate a request
        GameController.instance.request = RequestGenerator.Create();

        // Reset Risk
        GameController.instance.CurrentRisk = GameController.instance.StartingRisk;
        GraveUI.instance.SetRiskText();

        GraveUI.instance.SetRequestText(GameController.instance.request.LetterText);

        // Update letter text
        FindObjectOfType<Letter>(true).SetRequestText(GameController.instance.request.LetterText);

        // Show letter
        FindObjectOfType<Letter>(true).gameObject.SetActive(true);
    }

    public override void OnExit()
    {
        Debug.Log("Exiting new request.");

        FindObjectOfType<LabView>(true).gameObject.SetActive(false);
    }

    public override void OnRefresh()
    {
        
    }
}
