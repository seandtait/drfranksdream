using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("You LOSE!");

        GameController.instance.SetMoney(0);
        FindObjectOfType<LoseView>(true).gameObject.SetActive(true);
    }

    public override void OnExit()
    {
        Debug.Log("Lose Exit.");

        FindObjectOfType<LoseView>(true).gameObject.SetActive(false);
    }

    public override void OnRefresh()
    {
        
    }
}
