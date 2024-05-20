using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerButton : MonoBehaviour
{
    public static int Score = 0;

    private bool isCorrect;
    [SerializeField] private TextMeshProUGUI answerText;
    [SerializeField] private QuestionSetup questionSetup;
    private Button button;
    private Image buttonImage;
    [SerializeField] private Color defaultColor = Color.white; // Default button color
    [SerializeField] private Color correctColor = Color.green;
    [SerializeField] private Color incorrectColor = Color.red;
    [SerializeField] private List<AnswerButton> allAnswerButtons;

    private void Awake()
    {
        button = GetComponent<Button>();
        buttonImage = button.GetComponent<Image>();
    }

    public void SetAnswerText(string newText)
    {
        answerText.text = newText;
    }

    public void SetIsCorrect(bool newBool)
    {
        isCorrect = newBool;
    }

    public void OnClick()
    {
        if (isCorrect)
        {
            buttonImage.color = correctColor;
            Score += (int)(Timer.timeLeft);
            Timer.switchingScenes = true;
            Invoke("LoadNext", 1); // Load next question after 1 second
        }
        else
        {
            buttonImage.color = incorrectColor;
            Timer.switchingScenes = true;
            Invoke("GameOver", 1); // Go to game over scene after 1 second
        }

        DisableAllButtons(); // Disable all answer buttons
    }

    // Method to disable the button
    public void DisableButton()
    {
        button.interactable = false;
    }

    // Method to enable the button
    public void EnableButton()
    {
        button.interactable = true;
        buttonImage.color = defaultColor; // Reset button color to default
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver"); // Load game over scene
    }

    void LoadNext()
    {
        questionSetup.LoadNewQuestion(); // Load new question
        Timer.switchingScenes = false;
        Timer.timeLeft = 21.0f;
    }

    private void DisableAllButtons()
    {
        foreach (var btn in allAnswerButtons)
        {
            btn.DisableButton(); // Disable all answer buttons
        }
    }
}
