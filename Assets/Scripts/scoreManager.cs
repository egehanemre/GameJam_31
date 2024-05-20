using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext;

    // Start is called before the first frame update
    void Start()
    {
        Timer.timeLeft = 21.0f;
        scoretext.text = "Score: " + (AnswerButton.Score);
    }
}
