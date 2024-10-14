using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private PlayerInventoryDisplay playerInventoryDisplay;
    private bool carringStar = false;

    public void Awake()
    {
        playerInventoryDisplay = GetComponent<PlayerInventoryDisplay>();
    }

    public void Start()
    {
        playerInventoryDisplay.OnChangeCarringStar(carringStar);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Star"))
        {
            carringStar = true;
            playerInventoryDisplay.OnChangeCarringStar(carringStar);
            Destroy(collider.gameObject);
        }
    }
}