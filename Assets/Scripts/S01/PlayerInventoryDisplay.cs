using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public TextMeshProUGUI starText ;
    public void OnChangeCarringStar(bool carringStar){
        string message = "no star :-(";

        if(carringStar){
            message = "Carring star :-)";
        }
        starText.text = message;
    }
}
