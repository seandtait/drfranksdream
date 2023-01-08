using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private void Awake()
    {
        instance = this;
    }

    public State CurrentState;

    public Request request;

    public BodyPart SelectedBodyPart;
    public GameObject SelectedGrave;

    public int Shillings = 0;
    public TMPro.TextMeshProUGUI shillingText;

    public int TargetScore = 600;
    public int GameOverScore = -200;

    public int StartingRisk = 5;
    public int CurrentRisk = 0;

    public void GainMoney(int money)
    {
        Shillings += money;
        UpdateText();
    }

    public void SetMoney(int money)
    {
        Shillings = money;
        UpdateText();
    }

    void UpdateText()
    {
        shillingText.text = $"{Shillings.ToString()} / {TargetScore}";
    }

    // Start is called before the first frame update
    void Start()
    {
        ChangeState<IntroState>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentState == null)
            return;

        CurrentState.Refresh();
    }

    public void ChangeState<T>() where T : MonoBehaviour
    {
        RemoveCurrentState();

        gameObject.AddComponent<T>();
        CurrentState = GetComponent<State>();
        CurrentState.Enter();
    }

    public void RemoveCurrentState()
    {
        if (CurrentState != null)
        {
            CurrentState.Exit();
        }

        DestroyImmediate(CurrentState);
        CurrentState = null;
    }

}
