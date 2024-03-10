using UnityEngine;
using UnityEngine.UI;

public class EffectTransition : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Image _panel;

    private const float MaxAlfaChanel = 255;
    private int _isTransitionHash = Animator.StringToHash("isTransition");

    public void UseEffect(Color color)
    {
        _animator.SetTrigger(_isTransitionHash);
        color.a = MaxAlfaChanel;
        _panel.color = color;
    }
}
