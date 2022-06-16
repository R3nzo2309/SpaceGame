using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    [SerializeField] private GameObject fireworks;
    [SerializeField] private GameObject fireworksClone;
    ParticleSystem fireworksAll;
    [SerializeField] private string ship;

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
        if (collision.gameObject.CompareTag(ship))
        {
            lost();
        }


    }

    void lost()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("lost");
        Cursor.visible = true;
    }

    void Explode()
    {
        fireworksAll.Play();
        Destroy(fireworksClone, 0.5f);
    }



}
