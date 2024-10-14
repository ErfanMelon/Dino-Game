using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory4 : MonoBehaviour
{
    private PlayerInventoryDisplay4 playerInventoryDisplay;
    private int totalStar = 0;
    public void Awake()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay4>();
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