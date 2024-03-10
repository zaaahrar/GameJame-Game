using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(PlayerInput))]
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isGround;
    [SerializeField] private bool _isKnight;
    [SerializeField] private LayerMask _groundMask;

    private const float RayDistance = 1f;

    private Rigidbody2D _rigidbody2D;
    private PlayerInput _playerInput;
    private Animator _animator;

    private Vector3 _turnLeft = new Vector3(-1, 1, 0);
    private Vector3 _turnRight = new Vector3(1, 1, 0);

    private int _isMovementHash = Animator.StringToHash("isRun");

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput>();
    }

    private void FixedUpdate()
    {
        MoveHorizontally(_playerInput.HorizontalDirection);
        CheckGround();
    }

    private void MoveHorizontally(float horizontalDirection)
    {
        _animator.SetBool(_isMovementHash, true);
        _rigidbody2D.velocity = new Vector2(_playerInput.HorizontalDirection * _speed, _rigidbody2D.velocity.y);

        if (horizontalDirection > 0)
            transform.localScale = _turnLeft;
        else if (horizontalDirection < 0)
            transform.localScale = _turnRight;
        else
            _animator.SetBool(_isMovementHash, false);
    } 

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
