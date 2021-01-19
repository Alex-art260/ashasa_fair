using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMush : MonoBehaviour
{
    [SerializeField] private  GameObject[] _obj;

    Vector2 whereToSpawn;

    void Start()
    {
        StartCoroutine(MushSpawner());
    }


    private IEnumerator MushSpawner()
    {
        for(; ;)
        {
            whereToSpawn = new Vector2(-10, 2);
            Instantiate(_obj[Random.Range(0, 4)], whereToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
