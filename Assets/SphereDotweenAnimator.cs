using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SphereDotweenAnimator : MonoBehaviour
{

    public AnimationCurve animationCurve;
    private Vector3 originPosition;
    private float time;
    Vector3 endValue;
    void Start()
    {
        originPosition = transform.position;
        RandomVector();
    }

    private void RandomVector()
    {
        endValue = new Vector3(originPosition.x + Random.Range(-5f, 5f), originPosition.y + Random.Range(-5f, 5f), originPosition.z + Random.Range(-5f, 5f));
        transform.DOMove(endValue, 1f).SetEase(Ease.InOutElastic).OnComplete(RandomVector);
    }
}
