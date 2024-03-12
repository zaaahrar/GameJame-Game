using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private CounterPortal _counter;
    [SerializeField] private bool _isBlue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            if (_isBlue)
                _counter.AddBlue();
            else
                _counter.AddRed();


            if(_counter.CountBlue > _counter.CountRed)
                SceneManager.LoadScene(9);
            else if(_counter.CountRed > _counter.CountBlue)
                SceneManager.LoadScene(10);
        }
    }
}
