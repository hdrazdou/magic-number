using UnityEngine;

public class SumTheNum : MonoBehaviour
{
    #region Variables

    public int Max = 9;
    public int Min = 1;
    public int TargetSum = 50;
    private int _moves;
    private int _totalAmount;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        Debug.Log($"Press any digit from {Min} to {Max}.");
    }

    private void Update()
    {
        for (KeyCode key = KeyCode.Alpha0; key <= KeyCode.Alpha9; key++)
        {
            if (Input.GetKeyDown(key))
            {
                _getTheSum((int)key - 48);

                if (_totalAmount >= TargetSum)
                {
                    Debug.Log($"All done! You've reached {TargetSum} in {_moves} moves.");
                    Debug.Log("------------------------------------------------");
                    _totalAmount = 0;
                    _moves = 0;
                    Start();
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

    private void _getTheSum(int digit)
    {
        _totalAmount += digit;
        _moves++;
    }

    #endregion
}