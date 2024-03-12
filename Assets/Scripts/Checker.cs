using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    [SerializeField] private SceneLoader _loader;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _loader.LoadScene();
        }
    }
}
