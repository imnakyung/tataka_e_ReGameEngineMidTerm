using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject HelpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void OpenHelp()
    {
        HelpPanel.SetActive(true);
    }

    public void CloseHelp()
    {
        HelpPanel.SetActive(false);
    }
}
