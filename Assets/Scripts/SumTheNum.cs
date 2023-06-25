using UnityEngine;

public class SumTheNum : MonoBehaviour
{
    public int Min = 1;
    public int Max = 9;
    private int _totalAmount;
    private int _moves;
    public int TargetSum = 50;

    void Start()
    {
        Debug.Log($"Press any digit from {Min} to {Max}.");
    }

    void Update()
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

    private void _getTheSum(int digit)
    {
        _totalAmount += digit;
        _moves++;
    }
}