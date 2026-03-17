using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float corePower = 3f;
    public float speed = 5f;
    public GameObject core;

    private void Update()
    {
        HareketEttir();
        transform.position = Vector3.MoveTowards(transform.position, core.transform.position, corePower * Time.deltaTime);  // kürenin çekimi

    }

    public void HareketEttir()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(x, y,0);

        transform.Translate(Vector2.right * moveVector * Time.deltaTime * speed );
        transform.Translate(Vector2.up * moveVector * Time.deltaTime * speed);
    }
}
