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
        a.transform.position = new Vector2(20, Random.Range(-4.5f, 4.5f));
    }

    IEnumerator AstroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            SpawnEnemy();
        }
    }
}
