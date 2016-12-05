using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnumUI { All, NoteBook, Exit };

public class GUIManager : MonoBehaviour {

    public Floor floor;

    private GameObject g_notebook;
    private GameObject g_exit;

    // Use this for initialization
    void Start () {
        g_notebook = GameObject.FindGameObjectWithTag("NoteBook");
        g_exit = GameObject.FindGameObjectWithTag("Exit");

        g_notebook.SetActive(false);
        g_exit.SetActive(false);
    }
	
	public void showUI(EnumUI ui)
    {
        switch (ui)
        {
            case EnumUI.NoteBook:
                g_notebook.SetActive(true);
                g_exit.SetActive(false);
                break;
            case EnumUI.Exit:
                g_notebook.SetActive(false);
                g_exit.SetActive(true);
                floor.Desactivate();
                break;
            case EnumUI.All:
                g_notebook.SetActive(true);
                g_exit.SetActive(true);
                break;
        }
    }

    public void hideUI()
    {
        g_notebook.SetActive(false);
        g_exit.SetActive(false);
        floor.Activate();
    }
}
