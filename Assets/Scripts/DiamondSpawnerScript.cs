using UnityEngine;

public class DiamondSpawnerScript : MonoBehaviour
{
    public GameObject diamondPrefab;
    
    private void Start()
    {
        InvokeRepeating("DiamondSpawner", 0, 2f);
    }

    Vector3 spawnLocation;
    public void DiamondSpawner()
    {
        float x = Random.Range(-14, 14);
       

        spawnLocation = new Vector3(x, 5, 0);

        Instantiate(diamondPrefab, spawnLocation ,Quaternion.identity);
    }
}
