using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventoryDisplay6 : MonoBehaviour
{
    public PickupUI[] slots = new PickupUI[1];
    public void OnChangeStarTotal(int totalStar)
    {
        int numInventorySlots = slots.Length;
        for (int i = 0; i < numInventorySlots; i++)
        {
            PickupUI slot = slots[i];
            if (i < totalStar)
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
