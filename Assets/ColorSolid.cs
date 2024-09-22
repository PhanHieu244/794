using System;
using UnityEngine;

public class ColorSolid : MonoBehaviour
{
    private static ColorSolid _instance;
    [SerializeField] private Color color = Color.white;
    private void Awake()
    {
        // Check if another instance already exists
        if (_instance != null && _instance != this)
        {
            // If so, destroy the duplicate object
            Destroy(gameObject);
        }
        else
        {
            // If this is the first instance, set it and prevent it from being destroyed on load
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        if (Camera.main is null) return;
        Camera.main.backgroundColor = color;
    }
}
