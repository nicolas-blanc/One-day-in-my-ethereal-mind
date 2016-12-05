using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnumUI { All, NoteBook, Exit, Object };

public class GUIManager : MonoBehaviour {

    public Floor floor;

    private GameObject g_notebook;
    private GameObject g_exit;
    private GameObject g_object;

    // Use this for initialization
    void Start () {
        g_notebook = GameObject.FindGameObjectWithTag("NoteBook");
        g_exit = GameObject.FindGameObjectWithTag("Exit");
        g_object = GameObject.FindGameObjectWithTag("ObjectUI");

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
                floor.Desactivate();
                break;
            case EnumUI.Exit:
                g_notebook.SetActive(false);
                g_exit.SetActive(true);
                g_object.SetActive(false);
                floor.Desactivate();
                break;
            case EnumUI.Object:
                floor.Activate();
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

    public void hideUI()
    {
        g_notebook.SetActive(false);
        g_exit.SetActive(false);
        g_object.SetActive(false);
        floor.Activate();
    }
}
