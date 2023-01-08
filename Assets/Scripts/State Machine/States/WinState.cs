using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("You WIN!");

        GameController.instance.SetMoney(0);
        FindObjectOfType<WinView>(true).gameObject.SetActive(true);
    }

    public override void OnExit()
    {
        Debug.Log("Win Exit.");

        FindObjectOfType<WinView>(true).gameObject.SetActive(false);
    }

    public override void OnRefresh()
    {
        
    }
}
