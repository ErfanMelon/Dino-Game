using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventoryDisplay5 : MonoBehaviour
{
    public Image starPlaceHolder;

    public void OnChangeStarTotal(int totalStars)
    {
        starPlaceHolder.transform.position = new Vector3(totalStars * 50,starPlaceHolder.transform.position.y,starPlaceHolder.transform.position.z);
        float newWidth = 100 * totalStars;
        starPlaceHolder.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, newWidth);
    }
}
