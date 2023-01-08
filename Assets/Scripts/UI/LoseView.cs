using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseView : MonoBehaviour
{
    public void ClickedPlayAgain()
    {
        GameController.instance.ChangeState<CleanupState>();
    }
}
