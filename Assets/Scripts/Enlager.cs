using UnityEngine;
using DG.Tweening;

public class Enlager : MonoBehaviour
{
    private void Update()
    {
        transform.DOScale(3, 5);
    }
}
