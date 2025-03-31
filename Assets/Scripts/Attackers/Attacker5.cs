using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker5 : Attacker
{
 
    public Economy Eco;
    public float positionCounter = 0f;
    public Vector3 initialPosition;
    private float elapsedTime = 0f;
   private float totalDuration1 = 2f;
    private float totalDuration2 = 2f;
    private float totalDuration3 = 1.5f;
    private float totalDuration4 = 1.8f;
    private float totalDuration5 = 1.5f;
    private float totalDuration6 = 2.5f;
    private float totalDuration7 = 4f;
    int DropReward = 5;
    Vector3 forwardDirection = Vector3.up;

    // Start is called before the first frame update
    void Start()
    {
        
        Eco = GameObject.FindWithTag("ECO").GetComponent<Economy>();
        health = 15f;

        speed = 1f;
        
        initialPosition = transform.position;

        //Spawner = GameObject.Find("Attackers");
        //refObject = Spawner.transform;
        //rightDirection = refObject.right;
        //transform.forward = rightDirection;
    }

    // Update is called once per frame
    void Update()
    {

        if (positionCounter == 0f)
        {
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration1);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(-4.5f, 2.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 1f;
                initialPosition = transform.position;
                elapsedTime = 0f;
            }
        }
        if (positionCounter == 1f)
        {
            
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration2);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(-4.5f, -0.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 2f;
                initialPosition = transform.position;
                elapsedTime = 0f;
            }
        }
        if (positionCounter == 2f)
        {
            
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration3);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(-1.51f, -0.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 3f;
                initialPosition = transform.position;
                elapsedTime = 0f;
            }
        }
        if (positionCounter == 3f)
        {
            
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration4);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(-1.53f, 2.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 4f;
                initialPosition = transform.position;
                elapsedTime = 0f;
            }
        }
        if (positionCounter == 4f)
        {
            
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration5);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(1.49f, 2.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 5f;
                initialPosition = transform.position;
                elapsedTime = 0f;
            }
        }
        if (positionCounter == 5f)
        {
            
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration6);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(1.5f, -2.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 6f;
                initialPosition = transform.position;
                elapsedTime = 0f;
            }
        }
       if (positionCounter == 6f)

        {
            
            elapsedTime += Time.deltaTime;
            float normalizedTime = Mathf.Clamp01(elapsedTime / totalDuration7);
            //transform.position = forwardDirection;
            Vector3 movement = new Vector3(10.23f, -2.5f, 0f); 
            transform.position = Vector3.Lerp(initialPosition, movement, normalizedTime * speed);
            if (Vector3.Distance(transform.position, movement) < 0.01f)
            {
                positionCounter = 7f;
                Eco.GameHealth--;
                Destroy(gameObject);
            }
        }

        if (health <= 0)
        {
            Destroy(gameObject);
            Eco.money = Eco.money + DropReward;
        }
        
        
    
    }

    // public void OnTriggerEnter2D(Collider2D col)
    // {
    //     Debug.Log("collision detected with bullet");
    //      if(col.gameObject.tag == "Bullet")
    //     {
            
    //         health -= 1;
    //     }

    // }
}
