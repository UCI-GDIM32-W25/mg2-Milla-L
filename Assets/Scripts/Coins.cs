using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    [SerializeField] private GameObject _coinPrefab;
    [SerializeField] private int _coinsCaught;
    [SerializeField] private CoinUI _coinCount;

    private int _coins;
    void Start()
    {
        _coins = 0;
        _coinCount.UpdateCoins(_coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCoin()
    {
        GameObject coin = Instantiate(_coinPrefab);
        coin.gameObject.SetActive(true);
        _coins++;
    }
}
