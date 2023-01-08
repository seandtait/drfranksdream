using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewResultState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("Entering view result");

        Results results = FindObjectOfType<Results>(true);

        results.SetAttributeTotals(TableBody.instance.GetAttributeTotals());

        if (GameController.instance.request.IsSuccess(TableBody.instance))
        {
            results.SetRewardText(GameController.instance.request.GetReward() + GameController.instance.request.baseReward);
        } else
        {
            results.SetRewardText(-Mathf.Abs(GameController.instance.request.GetReward()));
        }

        results.SetRequestText(GameController.instance.request.LetterText);

        FindObjectOfType<GraveView>(true).gameObject.SetActive(false);
        results.gameObject.SetActive(true);
    }

    public override void OnExit()
    {
        Debug.Log("Exiting view result");

    }

    public override void OnRefresh()
    {
        
    }
}
