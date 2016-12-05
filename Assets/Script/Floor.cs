using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {

    public Player player;
    public GUIManager GUIMgr;

    public void Activate()
    {
        enabled = true;
    }

    public void Desactivate()
    {
        enabled = false;
    }

    void OnMouseUpAsButton()
    {
        if (enabled)
        {
            GUIMgr.hideUI();

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            player.GoToPosition(mousePos);
        }
    }
}
