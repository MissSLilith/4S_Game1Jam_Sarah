using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI cherryText;

    // Start is called before the first frame update
    void Start()
    {
        cherryText = GetComponent<TextMeshProUGUI>(); 
    }

    public void UpdateCherryText(PlayerInventory playerInventory)
    {
        cherryText.text = playerInventory.NumberOfCherries.ToString();
    }
}
