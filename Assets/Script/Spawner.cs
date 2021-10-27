using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float _spawntime = 0.1f;
    private float spawnTime {  get { return _spawntime; } }

    //private float currentSpawnTime { get; set; } = 0;

    public GameObject _enemyPrefab = null;
    private GameObject enemyPrefab { get { return _enemyPrefab; } }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnTime);
    }

    private void Spawn()
    {
        Vector3 randomPos = transform.position;
        randomPos.x += Random.Range(-3.0f, 3.0f);
        Instantiate(enemyPrefab, randomPos, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
