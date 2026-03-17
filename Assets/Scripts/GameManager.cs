using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float coinCount;
    
    public TextMeshProUGUI CoinTMP;

    public GameObject tekrarDeneBTN;
    private void Start()
    {
        coinCount = 0;
        UpdateScore();
    }

    public void ScoruArttýr()
    {
        coinCount++;
        UpdateScore();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        tekrarDeneBTN.SetActive(true);
        
    }

    public void UpdateScore()
    {
        CoinTMP.text = "Coin: " + coinCount;
    }

    public void OnClickTekrarDeneBTN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

}
