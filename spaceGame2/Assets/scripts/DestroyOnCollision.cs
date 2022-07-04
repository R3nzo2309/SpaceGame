using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    [SerializeField] private GameObject explosion;
    [SerializeField] private string ship;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        explosion = Instantiate(explosion, transform.position, Quaternion.identity);

        if (collision.gameObject)
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
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



}
