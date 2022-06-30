using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployStars : MonoBehaviour
{
    public GameObject StarsPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StarsWave());
    }

    private void SpawnEnemy()
    {
        GameObject a = Instantiate(StarsPrefab) as GameObject;
        a.transform.position = new Vector2(25, 0);
    }

    IEnumerator StarsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            SpawnEnemy();
        }
    }
}
