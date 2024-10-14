using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay4 : MonoBehaviour
{
    public Image[] starPlaceHolders;
    public Sprite iconNoStar;
    public Sprite iconStar;

    public void OnChangeStarTotal(int totalStars)
    {
        for (int i = 0; i < starPlaceHolders.Length; ++i)
        {
            if (i < totalStars)
            {
                starPlaceHolders[i].sprite = iconStar;
            }
            else
            {
                starPlaceHolders[i].sprite = iconNoStar;
            }
        }
    }
}
