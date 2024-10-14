using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory7 : MonoBehaviour
{
    private PlayerInventoryDisplay7 playerInventoryDisplay;
    private int totalHeart = 0;
    public void Awake()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay7>();
    }

    public void Start()
    {
        playerInventoryDisplay.OnChangeHeartTotal(totalHeart);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Heart"))
        {
            totalHeart++;
            playerInventoryDisplay.OnChangeHeartTotal(totalHeart);
            Destroy(collider.gameObject);
        }
    }
}