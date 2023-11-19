using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    private void Update()
    {
        transform.DORotate(new Vector3(0, 360, 0), 5, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetRelative().SetEase(Ease.Linear);
    }
}
