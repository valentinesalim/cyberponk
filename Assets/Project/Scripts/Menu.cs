using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onPressed() 
    {
        string buttonName = this.name;
        switch (buttonName)
        {
            case "PlayButton":
                SceneManager.LoadScene(1);
                break;
            case "Settings":
                Debug.Log("haven't done the settings page yet");
                break;
            default:
                Application.Quit();
                break;
        }
    }
}
