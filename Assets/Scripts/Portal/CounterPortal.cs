using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterPortal : MonoBehaviour
{
    [SerializeField] private int _countBlue;
    [SerializeField] private int _countRed;

    public int CountBlue => _countBlue;
    public int CountRed => _countRed;

    private void Awake()
    {
        _countBlue = PlayerPrefs.GetInt("CountBlue");
        _countRed = PlayerPrefs.GetInt("CountRed");
    }

    public void AddBlue()
    {
        _countBlue++;
        PlayerPrefs.SetInt("CountBlue", _countBlue);
    }

    public void AddRed()
    {
        _countRed++;
        PlayerPrefs.SetInt("CountRed", _countRed);
    }

    public void ResetCount()
    {
        _countRed = 0;
        PlayerPrefs.SetInt("CountRed", _countRed);
        _countBlue = 0;
        PlayerPrefs.SetInt("CountBlue", _countBlue);
    }
}
