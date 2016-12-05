using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour {
    /**
     * Permet de changer de scene sur le menu
     * */
    public void LoadByName(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    /**
     * Permet de quitter le jeu
     * */
    public void Quit()
    {
        Application.Quit();
    }
}
