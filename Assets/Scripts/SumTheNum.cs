using UnityEngine;

public class SumTheNum : MonoBehaviour
{
    #region Variables

    private const int _max = 9;
    private const int _min = 1;
    private const int KeyCodeOffset = 48;
    public int TargetSum = 50;

    private int _moves;
    private int _totalAmount;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        InitializeGame();
    }

    private void Update()
    {
        for (KeyCode key = KeyCode.Alpha1; key <= KeyCode.Alpha9; key++)
        {
            if (Input.GetKeyDown(key))
            {
                GetTheSum((int)key - KeyCodeOffset);

                if (_totalAmount >= TargetSum)
                {
                    Debug.Log($"All done! You've reached {TargetSum} in {_moves} moves.");
                    Debug.Log("------------------------------------------------");
                    InitializeGame();
                }

                else if (_totalAmount < TargetSum)
                {
                    Debug.Log($"You've reached {_totalAmount}, go on!");
                }
            }
        }
    }

    #endregion

    #region Private methods

    private void GetTheSum(int digit)
    {
        _totalAmount += digit;
        _moves++;
    }

    private void InitializeGame()
    {
        _totalAmount = 0;
        _moves = 0;
        Debug.Log($"Press any digit from {_min} to {_max}.");
    }

    #endregion
}