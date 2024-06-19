using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bananacollect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.CherriesCollected();
            gameObject.SetActive(false);
        }
    }

    
}
