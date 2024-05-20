using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.VisualScripting;

public class Timer : MonoBehaviour
{
    public static bool switchingScenes = false;
    public static float timeLeft = 21.0f;
    public TextMeshProUGUI timerText; 


    void Update()
    {
        if (switchingScenes == false)
        {
            timeLeft -= Time.deltaTime;
            timerText.text = ((int)timeLeft).ToString();
        }
        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}