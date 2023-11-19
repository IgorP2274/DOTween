using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.DOMove(new Vector3(0, 0, -5), 10, false).SetRelative().SetEase(Ease.Linear);
    }
}
