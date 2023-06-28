using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    #region Variables

    public int Max = 2000;
    public int Min = 1;

    private int _currentMax;
    private int _currentMin;

    private int _guess;
    private int _moves;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        InitializeGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _currentMax = _guess;
            CalcualateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _currentMin = _guess;
            CalcualateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Congrats! I've guessed, your number is {_guess}. It took {_moves} moves to guess.");
            Debug.Log("------------------------------------------------");
            InitializeGame();
        }
    }

    #endregion

    #region Private methods

    private void AskAboutGuess()
    {
        Debug.Log($"Your number is {_guess}?");
        _moves++;
    }

    private void CalcualateGuess()
    {
        _guess = (_currentMin + _currentMax) / 2;
    }

    private void InitializeGame()
    {
        _moves = 0;
        _guess = 0;
        _currentMax = Max;
        _currentMin = Min;
        Debug.Log($"Make a number from {Min} to {Max}.");
        CalcualateGuess();
        AskAboutGuess();
    }

    #endregion
}