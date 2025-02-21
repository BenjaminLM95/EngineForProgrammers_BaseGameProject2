using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinManagement : MonoBehaviour
{
    public string currentScene;
    public string oldScene;
    public GameObject coin01;
    public GameObject coin02;
    public GameObject coin03;
    public GameObject coin04;
    public GameObject coin05;

    public Coin _coin1 = new Coin();
    public Coin _coin2 = new Coin();
    public Coin _coin3 = new Coin();
    public Coin _coin4 = new Coin();
    public Coin _coin5 = new Coin();

    // Start is called before the first frame update
    void Start()
    {
        oldScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != oldScene)
        {
            currentScene = SceneManager.GetActiveScene().name;
            oldScene = currentScene; 
            SetCoin(currentScene);
        }

                  
    }

    public void SetCoin(string SceneName) 
    {
        switch (SceneName) 
        {
            case "Level1_AreaA":
                disactivateCoins();
                if (!_coin1.StartingCoin)
                {
                    _coin1.StartingCoin = true;
                    coin01.gameObject.SetActive(true);
                }
                break;

            case "Level1_AreaB":
                disactivateCoins();
                if (!_coin2.StartingCoin)
                {
                    _coin2.StartingCoin = true;
                    coin02.gameObject.SetActive(true);
                }

                if (!_coin3.StartingCoin)
                {
                    _coin3.StartingCoin = true;
                    coin03.gameObject.SetActive(true);
                }
                break;

            case "Level1_AreaC":
                disactivateCoins();
                if (!_coin4.StartingCoin)
                {
                    _coin4.StartingCoin = true;
                    coin04.gameObject.SetActive(true);
                }

                if (!_coin5.StartingCoin)
                {
                    _coin5.StartingCoin = true;
                    coin05.gameObject.SetActive(true);
                }
                break;

        }
    }

    public void setTheCoins() 
    {
        _coin1.StartingCoin = false;
        _coin2.StartingCoin = false;
        _coin3.StartingCoin = false;
        _coin4.StartingCoin = false;
        _coin5.StartingCoin = false;
    }

    public void disactivateCoins() 
    {
        coin01.gameObject.SetActive(false); 
        coin02.gameObject.SetActive(false);
        coin03.gameObject.SetActive(false);
        coin04.gameObject.SetActive(false);
        coin05.gameObject.SetActive(false);
    }

}
