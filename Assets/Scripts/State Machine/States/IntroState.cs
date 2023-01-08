using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroState : State
{
    

    public override void OnEnter()
    {
        Debug.Log("INTRO");

        // SHow intro scene
        IntroView intro = FindObjectOfType<IntroView>(true);
        intro.gameObject.SetActive(true);
        intro.HideScenes();
        StartCoroutine(intro.PlayIntro());
    }

    public override void OnExit()
    {
        Debug.Log("Intro Finished");

        
    }

    public override void OnRefresh()
    {
        if (IntroView.Instance.Continue)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            IntroView.Instance.Continue = true;
        }
    }
}
