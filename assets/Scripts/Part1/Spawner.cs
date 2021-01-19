using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _obj;
    [SerializeField] private GameObject _ashas;

    private int i = 0;
    private float _randomX;
    Vector2 whereToSpawn;
    [SerializeField] private float _spawnRate = 2f;
    private float _nextSpawn = 1.5f;
   
    private void Update()
    {
        if (Time.timeSinceLevelLoad > _nextSpawn)
        {
            _ashas.SetActive(true);
            _nextSpawn = Time.timeSinceLevelLoad + _spawnRate;
            _randomX = Random.Range(-6.9f, 6.9f);
            whereToSpawn = new Vector2(_randomX, transform.position.y);
            Instantiate(_obj[Random.Range(0, 3)], whereToSpawn, Quaternion.identity);
        }

    }
}
