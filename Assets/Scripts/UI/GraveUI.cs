using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GraveUI : MonoBehaviour
{
    public static GraveUI instance;

    private void Awake()
    {
        instance = this;
    }

    public List<Button> graves;
    public TMPro.TextMeshProUGUI bodyPartPrompt;
    public TMPro.TextMeshProUGUI Risk;

    public TMPro.TextMeshProUGUI RequestText;

    public void SetRequestText(string text)
    {
        RequestText.text = $"\"{text}\"";
    }

    public void SetRiskText()
    {
        Risk.text = $"({GameController.instance.CurrentRisk}% Chance to Get Caught)\r\n3 new bodies";
    }

    public void GraveClicked()
    {
        GameController.instance.SelectedGrave = EventSystem.current.currentSelectedGameObject.gameObject;
        GameController.instance.ChangeState<MovePartToTableState>();
    }

    public void TryAgainTomorrow()
    {
        GameController.instance.CurrentRisk *= 2;
        SetRiskText();
        GameController.instance.ChangeState<TryAgainState>();
    }

    public void CancelRequest()
    {
        GameController.instance.ChangeState<CancelRequestState>();
    }

    public void DisableAll()
    {
        SetAll(false);
    }

    public void EnableAll()
    {
        SetAll(true);
    }

    public void EnablePossible()
    {
        // Some graves don't have the requested part; ie, you can't get the brain from a decapitated corpse.
        // Make these not interactable
        foreach (var grave in graves)
        {
            int graveIndex = grave.GetComponent<Grave>().index;
            Corpse corpse = GraveBodies.instance.graves[graveIndex].GetComponentInChildren<Corpse>();
            if (corpse.GetBodyPart(GameController.instance.SelectedBodyPart))
            {
                grave.interactable = true;
                grave.GetComponentInParent<Outline>().enabled = true;
            }
        }
    }

    public void SetAll(bool value)
    {
        foreach (var grave in graves)
        {
            grave.interactable = value;
            grave.GetComponentInParent<Outline>().enabled = value;
        }
    }

    public void SetGraveText()
    {
        for (int i = 0; i < graves.Count; i++)
        {
            TMPro.TextMeshProUGUI textbox = graves[i].GetComponentInChildren<TMPro.TextMeshProUGUI>();
            SetGraveText(GraveBodies.instance.graves[i].GetComponentInChildren<Corpse>().gameObject, textbox);
        }
    }

    void SetGraveText(GameObject corpse, TMPro.TextMeshProUGUI textbox)
    {
        textbox.text = CorpseGenerator.GenerateText(corpse);
    }

}
