using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void Exit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void AuthorInfo()
    {
        _panel.SetActive(true);
    }

    public void CloseAuthorInfo()
    {
        _panel.SetActive(true);
    }
}
