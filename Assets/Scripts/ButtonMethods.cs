using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class ButtonMethods : MonoBehaviour
    {
        public static void OnExitButtonClicked()
        {
            if (Application.isEditor)
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            else
            {
                Application.Quit();
            }
        }

        public static void OnPlayAgainButtonClicked()
        {
            SceneManager.LoadScene("GameScene");
        }
        
        public static void OnStartButtonClicked()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}