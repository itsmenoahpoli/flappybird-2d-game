using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnInterval = 1.5f;
    public float heightRange = 0.45f;
    private float timer;

    private void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if (timer > spawnInterval)
        {
            SpawnPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange), 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
