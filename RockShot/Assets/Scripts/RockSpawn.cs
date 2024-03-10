using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RockSpawn : MonoBehaviour
{
    public GameObject[] rockPreFab;
    public float rockSpawnTime;

    [SerializeField]
    private Vector3 spawnDimensions;

    [SerializeField]
    private Transform spawnPos;

    private Vector3 spawnRand;

    float randX, randY, randZ;
    int rockType;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RockSpawner());
    }

    IEnumerator RockSpawner()
    {
        rockType = Random.Range(0, 5);
        if (rockType < 3)
        {
            rockType = 0;
        }
        else if (rockType < 4)
        {
            rockType = Random.Range(1, rockPreFab.Length);
        }
        else
        {
            rockType = 1;
        }
        
        //Calcualtes a random position for rock to spawn in designated location
        randX = Random.Range(-(spawnDimensions.x / 2), (spawnDimensions.x / 2));
        randZ = Random.Range(-(spawnDimensions.z / 2), (spawnDimensions.z / 2));
        randY = Random.Range(-(spawnDimensions.y / 2), (spawnDimensions.y / 2));
        spawnRand = new Vector3(randX, randY, randZ) + spawnPos.position;

        yield return new WaitForSeconds(rockSpawnTime);

        // Creates rock from prefab based on calculated random position
        Instantiate(rockPreFab[rockType], spawnRand, rockPreFab[rockType].transform.rotation);
        StartCoroutine(RockSpawner());
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(spawnPos.position, spawnDimensions);
    }
}
