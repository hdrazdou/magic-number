using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    public int Min = 1;
    public int Max = 2000;
    private int _guess;
    private int _moves;

    private void Start()
    {
        Debug.Log($"Make a number from {Min} to {Max}.");
        CalcualateGuess();
        AskAboutGuess();
    }

    private void AskAboutGuess()
    {
        Debug.Log($"Your number is {_guess}?");
        _moves++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Max = _guess;
            CalcualateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Min = _guess;
            CalcualateGuess();
            AskAboutGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Congrats! I've guessed, your number is {_guess}. It took {_moves} moves to guess.");
            Debug.Log("------------------------------------------------");
            Min = 1;
            Max = 2000;
            _moves = 0;
            _guess = 0;
            Start();
        }
    }

    private void CalcualateGuess()
    {
        _guess = (Min + Max) / 2;
    }
}