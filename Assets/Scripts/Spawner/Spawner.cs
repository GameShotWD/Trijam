using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> SpawnPoints = new List<GameObject>();
    [SerializeField] private List<GameObject> Enemies = new List<GameObject>();
    [SerializeField] int SpawnDelay = 10;
    [SerializeField] int SpawnCount = 5;
    private bool delay = false;

    private void Start()
    {
        GameObject[] spawner = GameObject.FindGameObjectsWithTag("Spawner");
        for (int i = 0; i < spawner.Length; i++) {
            SpawnPoints.Add(spawner[i]);
        }
         

    }
    private void Update()
    {
        if(!delay)
        {
            Spawn();
        }
    }
    private void Spawn()
    {
        if (SpawnPoints.Count > 0 && Enemies.Count > 0 )
        {
            for (int i = 0; i < SpawnCount; i++)
            {
                int SpawnerId = Random.Range(0, SpawnPoints.Count - 1);
                int EnemyId = Random.Range(0, Enemies.Count - 1);
                Instantiate(Enemies[EnemyId], SpawnPoints[SpawnerId].transform.position, SpawnPoints[SpawnerId].transform.rotation);
            }
            StartCoroutine(Wait());
            SpawnCount++;
        }
    }
    IEnumerator Wait()
    {
        delay = true;
        yield return new WaitForSeconds(SpawnDelay);
        delay = false;
    }
}
