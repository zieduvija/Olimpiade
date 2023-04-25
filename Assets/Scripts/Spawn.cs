using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    public int numberOfObjectsToSpawn = 10;

    public float spawnRadius = 10f;

    private void Start()
    {
        for (int i = 0; i < numberOfObjectsToSpawn; i++)
        {
            // Choose a random prefab from the array
            int randomPrefabIndex = Random.Range(0, prefabsToSpawn.Length);
            GameObject prefabToSpawn = prefabsToSpawn[randomPrefabIndex];

            // Generate a random position to spawn the prefab
            Vector3 randomSpawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;

            // Instantiate the prefab at the random position
            Instantiate(prefabToSpawn, randomSpawnPosition, Quaternion.identity);
        }
    }
}
