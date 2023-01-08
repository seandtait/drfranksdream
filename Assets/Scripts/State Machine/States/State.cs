using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public bool Active = false;

    public void Enter()
    {
        OnEnter();

        Active = true;
    }

    public void Exit()
    {
        Active = false;

        OnExit();
    }

    public void Refresh()
    {
        if (Active)
        {
            OnRefresh();
        }
    }

    public abstract void OnEnter();
    public abstract void OnExit();
    public abstract void OnRefresh();

}
