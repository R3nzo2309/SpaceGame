using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour
{
    public Sprite Full;
    public Sprite TwoLives;
    public Sprite OneLives;
    public Sprite Empty;

    public int imgNumberCount;

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            if (imgNumberCount == 0)
            {
                GetComponent<Image>().sprite = Full;
                imgNumberCount++;
            }
            if (imgNumberCount == 1)
            {
                GetComponent<Image>().sprite = TwoLives;
                imgNumberCount++;
            }
            if (imgNumberCount == 2)
            {
                GetComponent<Image>().sprite = OneLives;
                imgNumberCount++;
            }
            if (imgNumberCount == 3)
            {
                GetComponent<Image>().sprite = Empty;
                imgNumberCount = 0;
            }
        }
    }
}
