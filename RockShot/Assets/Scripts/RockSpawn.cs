using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RockSpawn : MonoBehaviour
{
    public GameObject rockPreFab;
    public float rockSpawnTime;

    [SerializeField]
    private Vector3 spawnDimensions;

    [SerializeField]
    private Transform spawnPos;

    private Vector3 spawnRand;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(rockSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator rockSpawn()
    {
        yield return new WaitForSeconds(rockSpawnTime);

        //Calcualtes a random position for rock to spawn in designated location
        float randX = Random.Range( -(spawnDimensions.x/2), (spawnDimensions.x/2) );
        float randZ = Random.Range( -(spawnDimensions.z / 2), (spawnDimensions.z / 2) );
        float randY = Random.Range( -(spawnDimensions.y / 2), (spawnDimensions.y / 2) );
        spawnRand = new Vector3(randX, randY, randZ) + spawnPos.position;

        // Creates rock from prefab based on calculated random position
        GameObject clone = Instantiate(rockPreFab, spawnRand, rockPreFab.transform.rotation);
        StartCoroutine(rockSpawn());
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(spawnPos.position, spawnDimensions);
    }
}
