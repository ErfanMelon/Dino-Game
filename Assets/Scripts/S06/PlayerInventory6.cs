using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory6 : MonoBehaviour
{
    private PlayerInventoryDisplay6 playerInventoryDisplay;
    private int totalStar = 0;
    public void Awake()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay6>();
    }

    public void Start()
    {
        playerInventoryDisplay.OnChangeStarTotal(totalStar);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Star"))
        {
            totalStar++;
            playerInventoryDisplay.OnChangeStarTotal(totalStar);
            Destroy(collider.gameObject);
        }
    }
}