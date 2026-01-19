using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] private CoinUI coinUI;
    [SerializeField] private Transform spawnpoint;
    public GameObject coinPrefab;

    public int _coins;
    private float spawnTimer;
    private float timer;

    void Start()
    {
        _coins = 0;
        SpawnTimer();
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= timer) 
        {
            CreateCoin();
            spawnTimer = 0f;
            SpawnTimer();
        }
    }

    public void SpawnTimer()
    {
        timer = Random.Range(0.2f, 1.5f);
    }

    public void CreateCoin()
    {
        Instantiate(coinPrefab, spawnpoint.position, Quaternion.identity);
    }

    public void AddCoin()
    {
        _coins++;
        coinUI.UpdateCoins(_coins);
    }
}
