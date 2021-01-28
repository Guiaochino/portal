using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    public Text text;
    private bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        text.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && won)
        {
            SceneManager.LoadScene("Level");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        text.color = new Color(0, 0, 0, 1);
        text.text = "You Won!\nPress \"Space\" to Restart\nthe Game!";
        won = true;
    }
}
