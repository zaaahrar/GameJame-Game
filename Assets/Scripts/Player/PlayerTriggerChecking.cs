using UnityEngine;

public class PlayerTriggerChecking : MonoBehaviour
{
    [SerializeField] private GameObject _panelTransitionScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Portal _))
            _panelTransitionScene.SetActive(true);
    }
}
