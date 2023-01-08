using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestCompleteState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("Entering request complete");

        if (GameController.instance.request.IsSuccess(TableBody.instance))
        {
            Success();
        }
        else
        {
            Failure();
        }

        FindObjectOfType<Results>(true).gameObject.SetActive(false);

        if (GameController.instance.Shillings >= GameController.instance.TargetScore)
        {
            GameController.instance.ChangeState<WinState>();
        } else if (GameController.instance.Shillings <= GameController.instance.GameOverScore)
        {
            GameController.instance.ChangeState<LoseState>();
        } else
        {
            GameController.instance.ChangeState<CleanupState>();
        }
    }

    void Success()
    {
        GameController.instance.GainMoney(GameController.instance.request.GetReward() + GameController.instance.request.baseReward);
    }

    void Failure()
    {
        GameController.instance.GainMoney(-Mathf.Abs(GameController.instance.request.GetReward()));
    }

    public override void OnExit()
    {
        Debug.Log("Exiting request complete");


    }

    public override void OnRefresh()
    {
        
    }
}
