using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject iconHeart;
    public GameObject iconNoHeart;
    public bool hasExtraLife = false;
    public void Awake(){
        ClearHeart();
    }
    public void DisplayHeart(){
        iconHeart.SetActive(true);
        iconNoHeart.SetActive(false);
    }

    public void ClearHeart(){
        iconHeart.SetActive(false);
        iconNoHeart.SetActive(true);
    }
}
