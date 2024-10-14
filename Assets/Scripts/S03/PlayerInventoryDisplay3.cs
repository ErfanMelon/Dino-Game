using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay3 : MonoBehaviour
{
    public Image imageStarGo;
    public Sprite iconNoStar;
    public Sprite iconStar;

    public void OnChangeCarringStar(bool carringStar)
    {
        if (carringStar)
        {
            imageStarGo.sprite = iconStar;
        }
        else
        {
            imageStarGo.sprite = iconNoStar;
        }
    }
}
