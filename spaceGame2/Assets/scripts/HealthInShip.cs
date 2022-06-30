using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthInShip : MonoBehaviour
{
    [SerializeField] private Sprite Full;
    [SerializeField] private Sprite TwoLives;
    [SerializeField] private Sprite OneLives;
    [SerializeField] private Sprite Empty;
    private Image image;


    void Awake()
    {
       // ui = GameObject.Find("spaceShip").GetComponent<UI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealtBar();
    }

    public void UpdateHealtBar()
    {
        if (UI.health == 0)
        {
            image.sprite = Full;
        }
        else if (UI.health == 1)
        {
            image.sprite = TwoLives;
        }

        else if (UI.health == 2)
        {
            image.sprite = OneLives;
        }

        else if (UI.health == 3)
        {
            image.sprite = Empty;
        }

    }
}
