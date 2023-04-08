using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class MASTERSCR : MonoBehaviour
{
    
    [SerializeField] GameObject[] column;
    [SerializeField] Transform bird;
    [SerializeField] Vector2 delta;
     Vector2 delta1;
     Vector2 delta2;
    [SerializeField] Rigidbody2D[] rb;


    Vector2 Force;
    Vector2 ColPos;
    public Vector3 pos;
    public bool IsDead = false;
    Vector2 stop;

    // Start is called before the first frame update
    void Start()
    {
        Force.x = -150;
        ColPos.x = 0;
        for (int i = 0; i < rb.Length; i++)
        {
            rb[i].AddForce(Force, ForceMode2D.Force);
        }
        stop.x = 0;
        stop.y = 0;
        delta1 = delta;
        delta2 = delta;
    }

    // Update is called once per frame
    
    void Update()
    {
        
        
        pos.x = bird.position.x + 20;
        pos.y = ColPos.y;

        if (!IsDead)
        {
            if (delta.x > 8)
                {
                ColPos.y = Random.Range(-4, 4);
                column[0].transform.SetPositionAndRotation(pos, Quaternion.identity);

            }
            delta.x = bird.position.x - column[0].transform.position.x;
            if (delta1.x > 8)
            {
                ColPos.y = Random.Range(-4, 4);
                column[1].transform.SetPositionAndRotation(pos, Quaternion.identity);
            }
            delta1.x = bird.position.x - column[1].transform.position.x;
            if (delta2.x > 8)
            {
                ColPos.y = Random.Range(-4, 4);
                column[2].transform.SetPositionAndRotation(pos, Quaternion.identity);
            }
            delta2.x = bird.position.x - column[2].transform.position.x;
        }
        else
        {
            for (int i = 0; i < rb.Length; i++)
            {


                rb[i].velocity = stop;
            }
        }
    }
}
