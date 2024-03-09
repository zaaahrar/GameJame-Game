using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private const string AxisHorizontal = "Horizontal";

    private const KeyCode KeyJump = KeyCode.Space;

    private float _horizontalDirection;
    private PlayerMovement _playerMovement;

    public float HorizontalDirection => _horizontalDirection;

    private void Awake() => _playerMovement = GetComponent<PlayerMovement>();

    private void Update()
    {
        _horizontalDirection = Input.GetAxisRaw(AxisHorizontal);

        if (Input.GetKeyDown(KeyJump))
            _playerMovement.TryJump();
    }
}
