using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventoryDisplay7 : MonoBehaviour
{
    public PickupUI2[] slots = new PickupUI2[1];
    public void OnChangeHeartTotal(int totalHeart)
    {
        int numInventorySlots = slots.Length;
        for (int i = 0; i < numInventorySlots; i++)
        {
            PickupUI2 slot = slots[i];
            if (i < totalHeart)
            {
                slot.DisplayColorIcon();
            }
            else
            {
                slot.DisplayGreyIcon();
            }
        }
    }
}
