using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D column;
    [SerializeField] Rigidbody2D BirdRb;
    [SerializeField] Vector2 JumpForce;
    [SerializeField] Text score;
    public int ScoreInt;
  
    bool fire1;
   
    void Start()
    {

        BirdRb = GetComponent<Rigidbody2D>();
        
    }
    Vector2 vel;
    private void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0) && GameObject.Find("MASTER").GetComponent<MASTERSCR>().IsDead == false) 
        {
            vel.y = 0;
            BirdRb.velocity = vel;
                BirdRb.AddForce(JumpForce, ForceMode2D.Impulse);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 bordervel;
        bordervel.x = 0;
        bordervel.y = 0;
       if (collision.CompareTag("border"))
        {
            column.velocity = bordervel;
            GameObject.Find("MASTER").GetComponent<MASTERSCR>().IsDead = true;
            
            BirdRb.bodyType = RigidbodyType2D.Static;
            //BirdRb.bodyType ;
        }
       else if (collision.CompareTag("score"))
        {
            ScoreInt++;
            score.text = ScoreInt.ToString();
        }
    }




}
