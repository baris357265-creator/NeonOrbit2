using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

    HealthScript healthScript;
    SilahScript silahScript;
    float mermiHizi;
    public Transform playerTransform;
    private void Start()
    {
        healthScript = FindAnyObjectByType<HealthScript>();
        silahScript = FindAnyObjectByType<SilahScript>();

        if (transform.position.x >= 0)
            mermiHizi = 10f;
        else
        {
            mermiHizi = -10f;
            transform.Rotate(0, 0, -180);
        }

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

   

    private void Update()
    {
        transform.Translate(transform.right *mermiHizi * Time.deltaTime);

        if (Mathf.Abs(transform.position.x - playerTransform.position.x ) > 20)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            healthScript.HasarAl();
            Destroy(gameObject);
        }else
        {
            
        }
    }
}
