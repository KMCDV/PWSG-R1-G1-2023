using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotionContainer : MonoBehaviour
{
    public GameEvent gameEventToRaiseOnInteraction;
    public HealthPotion HealthPotion;

    private void OnTriggerEnter(Collider other)
    {
        gameEventToRaiseOnInteraction.Fire();
    }
}
