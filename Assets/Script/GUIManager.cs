using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnumUI { All, NoteBook, Exit, Object };

public class GUIManager : MonoBehaviour {

    private Floor floor;

    private GameObject g_notebook;
    private GameObject g_exit;
    private GameObject g_object;

    // Use this for initialization
    void Start () {
        g_notebook = GameObject.FindWithTag("NoteBook");
        g_exit = GameObject.FindWithTag("Exit");
        g_object = GameObject.FindWithTag("ObjectUI");

        if (GameObject.FindWithTag("Floor") == null)
        {
            floor = null;
        }
        else
        {
            floor = GameObject.FindWithTag("Floor").GetComponent<Floor>();
        }

        g_notebook.SetActive(false);
        g_exit.SetActive(false);
        g_object.SetActive(false);
    }
	
	public void showUI(EnumUI ui)
    {
        switch (ui)
        {
            case EnumUI.NoteBook:
                g_notebook.SetActive(true);
                g_exit.SetActive(false);
                g_object.SetActive(false);
                if (floor) { floor.Desactivate(); }
                break;
            case EnumUI.Exit:
                g_notebook.SetActive(false);
                g_exit.SetActive(true);
                g_object.SetActive(false);
                if (floor) { floor.Desactivate(); }
                break;
            case EnumUI.Object:
                if (floor) { floor.Activate(); }
                g_notebook.SetActive(false);
                g_exit.SetActive(false);
                g_object.SetActive(true);
                break;
            case EnumUI.All:
                g_notebook.SetActive(true);
                g_exit.SetActive(true);
                g_object.SetActive(true);
                break;
        }
    }

    public void showUIExit()
    {
        showUI(EnumUI.Exit);
    }

    public void hideUI()
    {
        g_notebook.SetActive(false);
        g_exit.SetActive(false);
        g_object.SetActive(false);
        if (floor) { floor.Activate(); }
    }
}
