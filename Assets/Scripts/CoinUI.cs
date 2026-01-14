using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;

    public void UpdateCoins(int _coins)
    {
        _coinText.text = _coins.ToString();
    }
}
