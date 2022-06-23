using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployStars : MonoBehaviour
{
    public GameObject StarsPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AstroidWave());
    }

    private void SpawnEnemy()
    {
        GameObject B = Instantiate(StarsPrefab) as GameObject;
        B.transform.position = new Vector2(20, 0);
    }

    IEnumerator AstroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            SpawnEnemy();
        }
    }
}
