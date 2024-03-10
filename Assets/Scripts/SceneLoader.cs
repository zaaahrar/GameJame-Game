using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private int _sceneIndex;

    public void LoadScene() => SceneManager.LoadScene(_sceneIndex);
}
