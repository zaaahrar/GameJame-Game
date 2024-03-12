using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(PlayerTriggerChecking))]
public class Player : MonoBehaviour
{
    [SerializeField] private bool _canOpenPortal;
    [SerializeField] private float _delayTime;
    [SerializeField] private int _currentScene;
    [SerializeField] private Transform _startPoint;
    [SerializeField] private EffectTransition _transition;

    private WaitForSeconds _delay;
    private PlayerTriggerChecking _trigger;

    public bool CanOpenPortal => _canOpenPortal;
    public int CurrentScene => _currentScene;

    private void Awake()
    {
        _delay = new WaitForSeconds(_delayTime);
        _trigger = GetComponent<PlayerTriggerChecking>();
    }

    public void OpenPortal()
    {
        _canOpenPortal = false;
        StartCoroutine(OpenPortalDelay());
    }

    public void Die()
    {
        transform.position = _startPoint.position;
        _transition.UseEffect(Color.black);
    }

    private IEnumerator OpenPortalDelay()
    {
        yield return _delay;
        _canOpenPortal = true;
    }
}
