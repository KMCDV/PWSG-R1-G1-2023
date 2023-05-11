using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class HealthPotionCounter : MonoBehaviour
{
    public int healthPotionsPickedUp;

    public TextMeshProUGUI textMeshPro;
    private float originScale;



    public void UpdatePotionsPickedUp()
    {
        textMeshPro.transform.DOKill(true);
        healthPotionsPickedUp++;
        textMeshPro.text = healthPotionsPickedUp.ToString();
        textMeshPro.transform.DOScale(1.1f, .5f).SetRelative(true).SetEase(Ease.InOutQuad).SetLoops(2, LoopType.Yoyo);
        
    }
}
