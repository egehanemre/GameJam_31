using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void LoadScene()
    {
         SceneManager.LoadScene("Questions");
         AnswerButton.Score = 0;
         Timer.switchingScenes = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
