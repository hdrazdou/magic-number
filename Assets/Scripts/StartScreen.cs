using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class StartScreen : MonoBehaviour
    {
        #region Variables

        public Button ExitButton;
        public Button StartButton;

        #endregion

        #region Unity lifecycle

        private void Start()
        {
            StartButton.onClick.AddListener(ButtonMethods.OnStartButtonClicked);
            ExitButton.onClick.AddListener(ButtonMethods.OnExitButtonClicked);
        }

        #endregion
    }
}