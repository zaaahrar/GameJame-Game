using UnityEngine;

public class CheckerPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerInput player))
            player.SwitchPlayer.ProhibitShift();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out PlayerInput player))
            player.SwitchPlayer.AllowShift();
    }
}
