using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SceneScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoretext;
    void Update()
    {
        scoretext.text = "Score: " + (AnswerButton.Score);
    }
}
