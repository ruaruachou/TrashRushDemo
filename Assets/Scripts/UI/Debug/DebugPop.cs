using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugPop : MonoBehaviour
{
    [SerializeField] int coinsAdded = 500;
    [SerializeField] int premium = 10;


    public void Open()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        PlayerData.instance.Save();
        gameObject.SetActive(false);
    }

    public void AddCoins()
    {
        PlayerData.instance.coins += coinsAdded;
        PlayerData.instance.Save();
        //显示当前coins数量
        Debug.Log("当前coins数量：" + PlayerData.instance.coins);
    }

    public void AddPremium()
    {
        PlayerData.instance.premium += premium;
        PlayerData.instance.Save();
        Debug.Log("当前premium数量：" + PlayerData.instance.premium);
    }

}