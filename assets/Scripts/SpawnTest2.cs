using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTest2 : MonoBehaviour
{
    [SerializeField] private GameObject[] _obj;
   

    private int i = 0;
    float _random1 = 3;
    float _random2 = -3; 
    Vector2 whereToSpawn;
    [SerializeField] private float _spawnRate = 2f;
    private float _nextSpawn = 1.5f;

    private void Update()
    {
        if (Time.timeSinceLevelLoad > _nextSpawn)
        {
   
            _nextSpawn = Time.timeSinceLevelLoad + _spawnRate;

            whereToSpawn = new Vector2(Random.Range(_random1,_random2), transform.position.y);
            Instantiate(_obj[Random.Range(0, 2)], whereToSpawn, Quaternion.identity);
        }

    }
}
