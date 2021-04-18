using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverTitlsButtons : MonoBehaviour
{
    public void onPressed()
    {
        string buttonName = this.name;
        switch (buttonName)
        {
            case "PlayAgainButton" :
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
            default:
                Application.Quit();
                break;
        }
    }
}
