using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class FinishScreen : MonoBehaviour
    {
        #region Variables

        public TMP_Text CongratsLabel;

        public Button ExitButton;
        public Button PlayAgainButton;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            PlayAgainButton.onClick.AddListener(ButtonMethods.OnPlayAgainButtonClicked);
            ExitButton.onClick.AddListener(ButtonMethods.OnExitButtonClicked);
            CongratsLabel.text = $"Wow! It took {MagicNumbers.Moves} moves to guess!";
        }

        #endregion
    }
}