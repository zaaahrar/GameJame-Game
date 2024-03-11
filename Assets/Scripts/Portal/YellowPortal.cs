using UnityEngine;

public class YellowPortal : MonoBehaviour
{
    [SerializeField] private Transform _teleportPoint;
    [SerializeField] private EffectTransition _transition;
    [SerializeField] private float _xOffSet = 2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            if (player.CanOpenPortal)
            {
                player.transform.position = new Vector3(_teleportPoint.position.x + _xOffSet, _teleportPoint.position.y, _teleportPoint.position.z);
                _transition.UseEffect(Color.yellow);
                player.OpenPortal();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            if (player.CanOpenPortal)
            {
                player.transform.position = new Vector3(_teleportPoint.position.x + _xOffSet, _teleportPoint.position.y, _teleportPoint.position.z);
                _transition.UseEffect(Color.yellow);
                player.OpenPortal();
            }
        }
    }
}
