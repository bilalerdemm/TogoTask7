using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CollectableManager : MonoBehaviour
{
    private Vector3 originalScale, scaleTo;
    private void Start()
    {
        originalScale = transform.localScale;
        scaleTo = originalScale * 1.4f;

        OnScale();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Single"))
        {
            Destroy(gameObject);
            PlayerGameController.instance.score++;
        }
    }
    private void OnScale()
    {
        transform.DOScale(scaleTo, 1f)
            .SetEase(Ease.InOutSine)
            .OnComplete(() =>
            {
             transform.DOScale(originalScale,1f)
                .SetEase(Ease.OutBounce)
                //.SetDelay(2f)
                .OnComplete(OnScale);
            });
    }
}
