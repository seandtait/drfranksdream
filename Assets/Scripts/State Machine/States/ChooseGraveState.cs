using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseGraveState : State
{

    public override void OnEnter()
    {
        Debug.Log("Choose grave!");

        // Prompt the player
        GraveUI.instance.bodyPartPrompt.gameObject.SetActive(true);

        GraveUI.instance.bodyPartPrompt.text = $"Whose {GameController.instance.SelectedBodyPart.ToString()} do you want?";
        GraveUI.instance.EnablePossible();
    }

    public override void OnExit()
    {
        Debug.Log("Exiting choose grave");

        // Remove prompt
        GraveUI.instance.bodyPartPrompt.gameObject.SetActive(false);

        GraveUI.instance.bodyPartPrompt.text = "";
        GraveUI.instance.DisableAll();
    }

    public override void OnRefresh()
    {
        GetInput();
    }

    void GetInput()
    {
        CheckBack();
    }

    void CheckBack()
    {
        if (Input.GetMouseButtonUp(1))
        {
            // Back
            GameController.instance.SelectedBodyPart = BodyPart.None;
            GameController.instance.ChangeState<ChooseBodyPartState>();
        }
    }


}
