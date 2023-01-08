using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LabTable : MonoBehaviour
{
    public static LabTable instance;

    private void Awake()
    {
        instance = this;
    }

    Color EnabledColor = new Color(1f, 1f, 1f, 1f);
    Color DisabledColor = new Color(0.3f, 0.3f, 0.3f, 0.5f);

    public List<Button> bodyParts;

    public GameObject ClickBodyPartPrompt;

    public void BodyPartClicked()
    {
        GameController.instance.SelectedBodyPart = EventSystem.current.currentSelectedGameObject.gameObject.GetComponent<BodyPartButton>().part;
        GameController.instance.ChangeState<ChooseGraveState>();
    }

    public void DisableAll()
    {
        SetAll(false);
    }

    public void EnableAll()
    {
        SetAll(true);
    }

    public void EnableUnchosen()
    {
        foreach (var bodyPart in bodyParts)
        {
            BodyPart currentPart = bodyPart.GetComponent<BodyPartButton>().part;
            if (!TableBody.instance.HasPart(currentPart))
            {
                bodyPart.interactable = true;
            }
        }
    }

    public void SetAll(bool value)
    {
        foreach (var bodyPart in bodyParts)
        {
            bodyPart.interactable = value;
        }
    }

    public void DisableSprites()
    {
        foreach (var bodyPart in bodyParts)
        {
            DisableSprite(bodyPart.gameObject);
        }
    }

    public void EnableSprites()
    {
        foreach (var bodyPart in bodyParts)
        {
            if (TableBody.instance.HasPart(bodyPart.GetComponent<BodyPartButton>().part))
            {
                EnableSprite(bodyPart.gameObject);
            }
        }
    }

    void EnableSprite(GameObject partObj)
    {
        partObj.GetComponent<BodyPartButton>().sprite.color = EnabledColor;
    }

    void DisableSprite(GameObject partObj)
    {
        partObj.GetComponent<BodyPartButton>().sprite.color = DisabledColor;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
