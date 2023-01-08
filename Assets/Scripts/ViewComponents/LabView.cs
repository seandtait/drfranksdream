using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabView : MonoBehaviour
{
    public Button Door;
    public GameObject DoorClickPrompt;

    public void ClickedDoor()
    {
        // Show request
        GameController.instance.ChangeState<ViewRequestState>();
    }

    public void ClickedRequest()
    {
        // Move to Grave scene
        GameController.instance.ChangeState<ViewGravesState>();
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
