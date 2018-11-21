using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnPoints;

    private const float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    [Tooltip("Block PreFab")]
    public GameObject blockPrefab;

	void Update () {

        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

   
    void SpawnBlocks() {

        int x = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != x)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }

    }
}
