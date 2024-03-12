using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private CounterPortal _counter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            if(_counter.CountBlue > _counter.CountRed)
            {
                SceneManager.LoadScene(9);
                Debug.Log("ss");
            }
            else if(_counter.CountRed > _counter.CountBlue)
            {
                SceneManager.LoadScene(10);
                Debug.Log("ssss");
            }
        }
    }
}
