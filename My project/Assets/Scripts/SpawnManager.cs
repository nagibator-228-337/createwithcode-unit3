
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private float startDelay=2;
    private float repeatRate = 2;
    private PlayerController playerController;

    private  Vector3 spawnPos = new Vector3(25, 0, 0);

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        playerController=GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void SpawnObstacle(){
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
