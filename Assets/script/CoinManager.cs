using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public  class CoinManager: MonoBehaviour
{
    [SerializeField] float _coinscoreChangeInterval = 10f;
    public Text _coinText = default;
    int _coinscore = 0;
    int _maxcoin = 4000;
    int coin;


    void Start()
    {
   //  Coin  = GameObject.FindWithTag("Coin");
      
    }
    private void Awake()
    {
        _coinText = GameObject.Find("CoinText").GetComponent<Text>();
    }

    // Update is called once per frame

  public  void AddCoin(int coin)
    {
        int tempCoin = _coinscore;
        _coinscore = Mathf.Min(_coinscore + coin, _maxcoin);
        if (tempCoin != _maxcoin)
        {
            DOTween.To(() => tempCoin, x => { _coinText.text = x.ToString("0000"); }, _coinscore, _coinscoreChangeInterval)
               .OnComplete(() => _coinText.text = _coinscore.ToString("0000"));
        }
    }

   
    public void Update()
    {
        _coinText.text = _coinscore.ToString();
    }
    public  void CoinupA()
    {
        AddCoin(coin +=1000);
    }


    //private void OnTriggerEnter(Collider other)
    //{

    //}
}
