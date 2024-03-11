using System.Collections;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    [SerializeField] private Player _knight;
    [SerializeField] private Player _dewil;
    [SerializeField] private Camera _camera;
    [SerializeField] private EffectTransition _effectTransition;
    [SerializeField] private float _delayTime;
    [SerializeField] private bool _isShift = true;
    [SerializeField] private StartBackgroundMusic _backgroundMusic;

    private Player _activePlayer;
    private Player _inactivePlayer;
    private float _indenationY = 20;
    private WaitForSeconds _delay;

    private void Awake()
    {
        _delay = new WaitForSeconds(_delayTime);
        _activePlayer = _knight;
        _inactivePlayer = _dewil;
    }

    public void Switch()
    {
        if (_isShift)
        {
            UpdatePlayerPosition(_activePlayer, _inactivePlayer);

            if (_activePlayer == _knight)
            {
                _effectTransition.UseEffect(Color.red);
                SetActivePlayers(_dewil, _knight);
                _backgroundMusic.StartMusicDewil();
            }
            else
            {
                _effectTransition.UseEffect(Color.white);
                SetActivePlayers(_knight, _dewil);
                _backgroundMusic.StartMusicHero();
            }

            _indenationY *= -1;
            _camera.transform.position = new Vector3(_camera.transform.position.x, _camera.transform.position.y + _indenationY, _camera.transform.position.z);
            _isShift = false;
            StartCoroutine(ShiftDelay());
        }    
    }

    public void ProhibitShift() => _isShift = false;

    public void AllowShift() => _isShift = true;

    private void UpdatePlayerPosition(Player activePlayer, Player inactivePlayer)
    {
        inactivePlayer.transform.position = new Vector2(_activePlayer.transform.position.x, _activePlayer.transform.position.y + (_indenationY * -1));
    }

    private void SetActivePlayers(Player playerTurnOn, Player playerTurnOff)
    {
        playerTurnOn.gameObject.SetActive(true);
        playerTurnOff.gameObject.SetActive(false);
        _activePlayer = playerTurnOn;
        _inactivePlayer = playerTurnOff;
    }

    private IEnumerator ShiftDelay()
    {
        yield return _delay;
        _isShift = true;
    }
}
