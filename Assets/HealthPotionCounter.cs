using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthPotionCounter : MonoBehaviour
{
    public int healthPotionsPickedUp;

    public TextMeshProUGUI textMeshPro;

    public void UpdatePotionsPickedUp()
    {
        healthPotionsPickedUp++;
        textMeshPro.text = healthPotionsPickedUp.ToString();
    }
}
