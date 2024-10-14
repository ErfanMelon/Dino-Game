using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory2 : MonoBehaviour
{
    private PlayerInventoryDisplay2 playerInventoryDisplay;
    private int totalStar = 0;
    public void Awake()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay2>();
    }

    public void Start()
    {
        playerInventoryDisplay.OnChangeCarringStar(totalStar);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Star"))
        {
            totalStar++;
            playerInventoryDisplay.OnChangeCarringStar(totalStar);
            Destroy(collider.gameObject);
        }
    }
}