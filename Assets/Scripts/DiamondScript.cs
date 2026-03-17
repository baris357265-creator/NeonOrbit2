using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    
    PlayerController controller;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        controller = FindAnyObjectByType<PlayerController>();
        
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, controller.core.transform.position, controller.corePower * Time.deltaTime);

        if (this.transform.position == controller.core.transform.position)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.tag == "Player")
        {
            gameManager.ScoruArttýr();
            Destroy(gameObject);
        }
    }

 

    

}
