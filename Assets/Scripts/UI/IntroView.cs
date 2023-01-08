using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroView : MonoBehaviour
{
    public static IntroView Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<GameObject> IntroScenes;

    public bool Continue = false;

    public void HideScenes()
    {
        for (int i = 0; i < IntroScenes.Count; i++)
        {
            IntroScenes[i].SetActive(false);
        }
    }

    public IEnumerator PlayIntro()
    {
        IntroScenes[0].SetActive(true);
        while (!Continue)
        {
            yield return null;
        }
        Continue = false;
        IntroScenes[1].SetActive(true);
        IntroScenes[0].SetActive(false);
        while (!Continue)
        {
            yield return null;
        }
        Continue = false;
        IntroScenes[2].SetActive(true);
        IntroScenes[1].SetActive(false);
        while (!Continue)
        {
            yield return null;
        }
        Continue = false;
        IntroScenes[3].SetActive(true);
        IntroScenes[2].SetActive(false);
        while (!Continue)
        {
            yield return null;
        }
        GameController.instance.ChangeState<CleanupState>();
    }


}
