using UnityEngine;

public class PlayerTriggerChecking : MonoBehaviour
{
    [SerializeField] private GameObject _panelTransitionScene;
    [SerializeField] private CounterPortal _portal;

    public GameObject PanelTransitionScene => _panelTransitionScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out BluePortal _))
        {
            _panelTransitionScene.SetActive(true);
            _portal.AddBlue();
        }
        if(collision.TryGetComponent(out RedPortal _))
        {
            _panelTransitionScene.SetActive(true);
            _portal.AddRed();
        }
    }
}
