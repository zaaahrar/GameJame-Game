using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{
    [SerializeField] private Player _knight;
    [SerializeField] private Player _dewil;
    [SerializeField] private Camera _camera;

    private Player _activePlayer;
    private Player _inactivePlayer;
    private float _indenationY = 20;

    private void Start()
    {
        _activePlayer = _knight;
        _inactivePlayer = _dewil;
    }

    public void Switch()
    {
        UpdatePlayerPosition(_activePlayer, _inactivePlayer);

        if (_activePlayer == _knight)
            SetActivePlayers(_dewil, _knight);
        else
            SetActivePlayers(_knight, _dewil);

        _indenationY *= -1;
        _camera.transform.position = new Vector3(_camera.transform.position.x, _camera.transform.position.y + _indenationY, _camera.transform.position.z);
    }

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
}
