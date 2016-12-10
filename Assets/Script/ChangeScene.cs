using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    /**
     * Permet de changer de scene sur le menu
     * */
    public void LoadByName(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
//         Scene scene = SceneManager.GetSceneByBuildIndex(sceneName);
//         SceneManager.MoveGameObjectToScene(GameObject.FindWithTag("ConstantObject"), scene);
    }

    /**
     * Permet de quitter le jeu
     * */
    public void Quit()
    {
        Application.Quit();
    }
}
