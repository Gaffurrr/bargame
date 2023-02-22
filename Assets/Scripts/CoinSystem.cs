using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinSystem : MonoBehaviour
{
    public TMP_Text coinsText;
    public static int coins;
    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
    }
    void Update()
    {
        coins = PlayerPrefs.GetInt("Coins");
        coinsText.text = "Coins: " + coins.ToString();
    }
    public void goToShop()
    {
        PlayerPrefs.SetInt("Coins", coins);
    }
}
