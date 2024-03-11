using UnityEngine;

public class StartBackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSourceHero;
    [SerializeField] private AudioSource _audioSourceDewil;
    [SerializeField] private float _maxValue;

    private void Awake()
    {
        StartMusicHero();
    }

    public void StartMusicHero()
    {
        _audioSourceDewil.volume = 0;
        _audioSourceHero.volume = _maxValue;
    }

    public void StartMusicDewil()
    {
        _audioSourceHero.volume = 0;
        _audioSourceDewil.volume = _maxValue;
    }
}
