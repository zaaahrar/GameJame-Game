using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveCounter : MonoBehaviour
{
    [SerializeField] private CounterPortal portal;

    private void Awake()
    {
        portal.ResetCount();
    }
}
