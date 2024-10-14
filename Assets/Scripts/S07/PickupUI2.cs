using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupUI2 : MonoBehaviour
{
    public GameObject iconColor;
    public GameObject iconGrey;

    void Awake()
    {
        DisplayEmpty();
    }

    public void DisplayColorIcon()
    {
        iconColor.SetActive(true);
        iconGrey.SetActive(false);
    }

    public void DisplayGreyIcon()
    {
        iconColor.SetActive(false);
        iconGrey.SetActive(true);
    }

    public void DisplayEmpty()
    {
        iconColor.SetActive(false);
        iconGrey.SetActive(false);
    }
}
