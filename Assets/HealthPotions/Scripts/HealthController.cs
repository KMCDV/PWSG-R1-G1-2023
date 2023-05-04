using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        HealthPotionContainer interactedPotion = other.GetComponent<HealthPotionContainer>();


        if(interactedPotion != null)
        {
            Debug.Log(interactedPotion.HealthPotion.healthToHeal);
        }
    }
}
