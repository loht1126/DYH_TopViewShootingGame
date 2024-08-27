using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("onspawnerstart");
    }
    public Transform[] spawnpoints;
    public GameObject prefab_enemy;
    
    private void spawnenemyonce()
    {
        int _posIndox = Random.Range(0, spawnpoints.Length);

        Transform _tr = spawnpoints[_posIndox];
        Instantiate(prefab_enemy, _tr.position, Quaternion.identity);
    }
    private IEnumerator onspawnerstart()
    {
        yield return null;
        while (true)
        {
            spawnenemyonce();
            yield return new WaitForSeconds(1.0f);
        }
    }
}
