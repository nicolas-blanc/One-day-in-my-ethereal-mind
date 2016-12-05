using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    public Player player;
    public GUIManager GUIMgr;

    public bool walkable;

    void OnMouseUpAsButton()
    {
        if (walkable)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            player.GoToPosition(mousePos);
        }

        GUIMgr.showUI(EnumUI.Exit);
    }

    public void hideUI()
    {
        GUIMgr.hideUI();
    }
}
