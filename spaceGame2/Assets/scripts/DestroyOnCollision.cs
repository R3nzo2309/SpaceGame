using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    [SerializeField] private GameObject fireworks;
    [SerializeField] private GameObject fireworksClone;
    ParticleSystem fireworksAll;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        fireworksClone = Instantiate(fireworks);
        fireworksAll = fireworksClone.GetComponent<ParticleSystem>();

        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Explode();
        }
        
    }
    void Explode()
    {
        fireworksAll.Play();
        Destroy(fireworksClone, 0.5f);
    }



}
