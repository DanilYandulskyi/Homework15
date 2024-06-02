using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private List<Transform> _transforms;

    private int _maxYRotation = 180;
    private int _waitTime = 2;

    private void Awake()
    {
        StartCoroutine(SpawnEnemies());
    }

    private void Spawn()
    {
        Vector3 position = _transforms[Random.Range(0, _transforms.Count)].position;

        Enemy enemy = Instantiate(_enemy, position, Quaternion.identity);

        enemy.transform.Rotate(0, Random.Range(0, _maxYRotation), 0);
    }

    private IEnumerator SpawnEnemies()
    {
        bool isSpawning = true;

        while (isSpawning)
        {
            yield return new WaitForSeconds(_waitTime);
            Spawn();
        }
    }
}
