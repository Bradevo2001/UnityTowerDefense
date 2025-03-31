using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Def4Bullet : MonoBehaviour
{
    //public At
    //Rigidbody rb;
    //private float totalDuration = 0.5f;
    float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
            // elapsedTime += Time.deltaTime;
            // float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration);
            // transform.position = forwardDirection;
            // Vector3 movement = new Vector3(-4.88f, 2.57f, 0f); 
            // transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
       //rb.velocity = transform.forward * speed;
       transform.position += transform.up * Time.deltaTime * speed;
        
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
         //Debug.Log("collision detected with " + col.gameObject.tag);
        if(col.gameObject.tag == "Attackers")
        {
            Debug.Log("collision detected");
            Attacker other = col.gameObject.GetComponent<Attacker>();
            other.health -= 1;
            Destroy(gameObject);

        }

    }

}
