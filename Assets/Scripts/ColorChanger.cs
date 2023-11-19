using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        _renderer.material.DOColor(Color.red, 5);
    }
}
