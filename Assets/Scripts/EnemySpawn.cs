using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    [SerializeField] GameObject[] _spawnPoints;
    [SerializeField] GameObject _enemy;
    float _spawnTimer=2f;
    float _spawnRateIncrease=5f;
    void Start()
    {
        StartCoroutine(SpawnNextEnemy());
        StartCoroutine(SpawnRateIncrease());
    }

    // Update is called once per frame
    IEnumerator SpawnNextEnemy()
    {
        
            int randomSpawnPoint=Random.Range(0,_spawnPoints.Length);
            Instantiate(_enemy,_spawnPoints[randomSpawnPoint].transform.position,Quaternion.identity);
            yield return new WaitForSeconds(_spawnTimer);
            if(!_gameManager._gameover)
            {
                StartCoroutine(SpawnNextEnemy());
            }
            
       
    }
    IEnumerator SpawnRateIncrease()
    {
        yield return new WaitForSeconds(_spawnRateIncrease);
        if(_spawnTimer>=0.5f)
        {
            _spawnTimer-=0.2f;
        }
        StartCoroutine(SpawnRateIncrease());
    }
}
