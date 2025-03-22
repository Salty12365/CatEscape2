using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    GameObject hpGauge;
    public GameObject gameOver_Text;

    public float myHP;
    public float fullHP = 100;


    void Start()
    {
        myHP = fullHP;
        hpGauge = GameObject.Find("hpGauge");
    }

    public void HurtHP()
    {
        myHP -= 20;

        hpGauge.GetComponent<Image>().fillAmount = myHP/fullHP;

        Debug.Log("ÇöÀç FillAmpopund °ª : " + hpGauge.GetComponent<Image>().fillAmount);

        if (myHP <= 0)
        {
            gameOver_Text.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
