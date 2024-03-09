using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isGround;
    [SerializeField] private LayerMask _groundMask;

    private const float RayDistance = 1f;

    private Rigidbody2D _rigidbody2D;
    private PlayerInput _playerInput;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        Move();
        CheckGround();
    }

    private void Move() => _rigidbody2D.velocity = new Vector2(_playerInput.HorizontalDirection * _speed, _rigidbody2D.velocity.y);

    private void CheckGround()
    {
        RaycastHit2D hit = Physics2D.Raycast(_rigidbody2D.position, Vector2.down, RayDistance, _groundMask);
        _isGround = hit.collider != null;
    }

    public void TryJump()
    {
        if (_isGround)
            _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
