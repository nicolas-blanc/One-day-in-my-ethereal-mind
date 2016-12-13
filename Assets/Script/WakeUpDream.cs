using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUpDream : MonoBehaviour {
    public GUIManager GUIMgr;

    private GameObject UILeave;

    private void Start()
    {
        UILeave = GameObject.FindWithTag("WakeUpDream");
        UILeave.SetActive(false);
    }

    public void Leave()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }

    void OnMouseUpAsButton()
    {
        if (ConstantObject.getTime() != TimeDay.TimeToSleep)
        {
            GUIMgr.showUI(EnumUI.DeactivateAll);
            UILeave.SetActive(true);
        }
        else
        {
            GUIMgr.showUI(EnumUI.DeactivateAll);
            // Change for endGame
            UILeave.SetActive(true);
        }
    }
}
