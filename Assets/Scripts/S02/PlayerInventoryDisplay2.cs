using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventoryDisplay2 : MonoBehaviour
{
    public TextMeshProUGUI starText ;
    public void OnChangeCarringStar(int totalStar){
        string message = $"total stars : {totalStar}";
        starText.text = message;
    }
}
