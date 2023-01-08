using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelRequestState : State
{
    
    public override void OnEnter()
    {
        Debug.Log("Cancel Request");

        GameController.instance.ChangeState<CleanupState>();
    }

    public override void OnExit()
    {
        Debug.Log("Cancel request.");


    }

    public override void OnRefresh()
    {
        
    }
}
