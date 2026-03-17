using UnityEngine;
using TMPro;

public class HealthScript : MonoBehaviour
{
    public float canSayisi;
    GameManager gameManager;

    public TextMeshProUGUI canSayisiTMP;
    private void Start()
    {
        canSayisi = 3;
        gameManager = FindAnyObjectByType<GameManager>();
        UpdateCanSayisi();
    }

    public void HasarAl()
    {
        canSayisi--;
        UpdateCanSayisi() ;
        if(canSayisi <= 0)
        {
            
            gameManager.GameOver();
        }
        

       
    }

    public void UpdateCanSayisi()
    {
        canSayisiTMP.text = "Kalan Can: " + canSayisi;
    }
}
