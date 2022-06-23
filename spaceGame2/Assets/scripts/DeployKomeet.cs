using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployKomeet : MonoBehaviour
{
    public GameObject komeetPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AstroidWave());
    }

    private void SpawnEnemy()
    {
        GameObject a = Instantiate(komeetPrefab) as GameObject;
        a.transform.position = new Vector2(15, Random.Range(-5, 5));
    }

    IEnumerator AstroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.4f);
            SpawnEnemy();
        }
    }
}
