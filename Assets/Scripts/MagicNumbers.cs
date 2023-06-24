using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    public int Min = 1;
    public int Max = 3000;
    private int _guess;
    
    private void Start()
    {
        Debug.Log($"Make a number from {Min} to {Max}.");
        CalcualateGuess();
        AskAboutGuess();
    }

    private void AskAboutGuess()
    {
        Debug.Log($"Your number is {_guess}?");
    }

    // Update is called once per frame
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
            Debug.Log($"Congrats! I've guessed, your number is {_guess}.");
        }
    }

    private void CalcualateGuess()
    {
        _guess = (Min + Max) / 2;
    }
}
