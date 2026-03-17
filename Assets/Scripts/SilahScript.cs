using UnityEngine;

public class SilahScript : MonoBehaviour
{
    [SerializeField]
    Vector3 ustSinir;
    [SerializeField]
    Vector3 altSinir;

    public GameObject projectile;

    public float SilahHizi = 1.6f;
    public float MermiAtmaHizi = 2f;

    private void Start()
    {
        InvokeRepeating("MermiAt", 1f, MermiAtmaHizi);
    }
    private void Update()
    {
        SilahHareket();
        
    }
    public void SilahHareket()
    {
        if(transform.position.y >= altSinir.y && transform.position.y <= ustSinir.y)
        {
            float zaman = Mathf.PingPong(Time.time *SilahHizi , 1f);
            transform.position = Vector3.Lerp(altSinir, ustSinir, zaman );
        }else
        {
            
        }
    }
    public float mermiHizi;
    
    public void MermiAt()
    {
        GameObject yeniMermi = Instantiate(projectile, transform.position, transform.rotation);       
    }
}
