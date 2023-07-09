using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public TMP_Text CurrentGuess;

    public TMP_Text DescriptionLabel;

    public Button ExactButton;
    public Button HigherButton;
    public Button LowerButton;

    public int Max = 2000;
    public int Min = 1;

    public static int Moves;
    public TMP_Text MovesCounter;

    private int _currentMax;
    private int _currentMin;
    private int _guess;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Moves = 0;
        _guess = 0;
        _currentMax = Max;
        _currentMin = Min;
        DescriptionLabel.text = $"Make a number from {Min} to {Max}.";
        MovesCounter.text = $"Moves: {Moves}";
        CalcualateGuess();
        AskAboutGuess();
        LowerButton.onClick.AddListener(OnLowerButtonClicked);
        HigherButton.onClick.AddListener(OnHigherButtonClicked);
        ExactButton.onClick.AddListener(OnExactButtonClicked);
    }

    #endregion

    #region Public methods

    public void OnExactButtonClicked()
    {
        SceneManager.LoadScene("FinishScene");
    }

    public void OnHigherButtonClicked()
    {
        _currentMin = _guess;
        UpdateMovesCounter();
        CalcualateGuess();
        AskAboutGuess();
    }

    public void OnLowerButtonClicked()
    {
        _currentMax = _guess;
        UpdateMovesCounter();
        CalcualateGuess();
        AskAboutGuess();
    }

    #endregion

    #region Private methods

    private void AskAboutGuess()
    {
        CurrentGuess.text = $"Your number is {_guess}?";
    }

    private void CalcualateGuess()
    {
        _guess = (_currentMin + _currentMax) / 2;
    }

    private void UpdateMovesCounter()
    {
        Moves++;
        MovesCounter.text = $"Moves: {Moves}";
    }

    #endregion
}