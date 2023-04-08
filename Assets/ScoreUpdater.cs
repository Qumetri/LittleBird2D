using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    [SerializeField] Text Score;
    //[SerializeField] Collider col;
    //Rigidbody2D rb;
    public int score;
    private void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {



       // if (collision.CompareTag("Bird"))
       // {
            score++;
            Score.text = score.ToString();
        //}
    }
}
