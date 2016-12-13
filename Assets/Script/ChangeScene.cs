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
        Scene scene = SceneManager.GetActiveScene();
        if (scene.buildIndex != 1)
        {
            ConstantObject.nextTimeDay();
            if (ConstantObject.getTime() == TimeDay.TimeToSleep)
            {
                if (scene.buildIndex == 2)
                {
                    SceneManager.LoadScene(0);
                }
                else
                {
                    SceneManager.LoadScene(2);
                }
            }
            else
            {
                SceneManager.LoadScene(sceneName);
            }

        }
        else
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    /**
     * Permet de quitter le jeu
     * */
    public void Quit()
    {
        Application.Quit();
    }
}
