using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Defender1 : Defender
{
    public GameObject Bullet;


    public Economy Eco;
    public float speed;
    public float rotationModifier;
    
    private Color Level2Colour = Color.yellow;
    private Color Level3Colour = Color.red;

    public bool shooting = false;
    float rateOfFire = 0.5f;
 
    public bool placedDown = false;
    public bool canPlaceDown = true;
    public List<Attacker> allAttackers = new List<Attacker>();
    public Attacker nearestAttacker;

    public Quaternion TurnAngleHP;
    public float HighestHealth = 0;
    public Attacker HighestHPAttacker;
    float distance;
    float nearestDistance = 1000000;
    public CircleCollider2D circleCollider;
    //public BoxCollider2D boxCollider;
    public Quaternion TurnAngle;

    float extraAngle = -90f;
    int cost = 100;

    
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        upgradeCost = 200;
        Eco = GameObject.FindWithTag("ECO").GetComponent<Economy>();
        placedDown = false;
        TargetMode = true;// true = target nearest , false = target highest HP
        if (shooting == false)
        {
            StartCoroutine(Shoot());
            shooting = true;

        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
        if (placedDown == false)
        {
            transform.position = worldPos;
            if (Input.GetMouseButtonDown(0) && Eco.money > cost && canPlaceDown == true)
            {
                placedDown = true;
                Eco.money = Eco.money -cost;
            }
            if (Input.GetMouseButtonDown(1))
            {
                Destroy(gameObject);
            }
        }
        if (placedDown == true)
        {
           // boxCollider.enabled = false;
            nearestDistance = 1000000;
            for (int i = 0; i < allAttackers.Count; i++)
            {

                    distance = Vector3.Distance(this.transform.position, allAttackers[i].transform.position);
                
                    if(distance < nearestDistance)
                    {
                        nearestAttacker = allAttackers[i];
                        nearestDistance = distance;
                        if (TargetMode == true)
                        {  
                            Vector3 vectorToTarget = nearestAttacker.transform.position - transform.position;
                            float angle = Mathf.Atan2(vectorToTarget.y,vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
                            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                            transform.rotation = Quaternion.Slerp(transform.rotation,q,Time.deltaTime*speed);
                            TurnAngle = transform.rotation;
                        }
                    }
                
                
                    if (allAttackers[i].health >= HighestHealth)
                    {
                    HighestHPAttacker = allAttackers[i];
                    HighestHealth = allAttackers[i].health;
                        if (TargetMode == false)
                        {
                            Vector3 vectorToTarget = HighestHPAttacker.transform.position - transform.position;
                            float angle = Mathf.Atan2(vectorToTarget.y,vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
                            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                            transform.rotation = Quaternion.Slerp(transform.rotation,q,Time.deltaTime*speed);
                            TurnAngleHP = transform.rotation;
                        }
                    }
                

            }
        }
    }


    public void ChangeFiringMode()
    {
        if (TargetMode == true)
        {
            Debug.Log("Changed Firing Mode to HP");
            TargetMode = false;
        }
        else 
        {
            Debug.Log("Changed Firing Mode to nearest");
            TargetMode = true;
        }
    }
    public void Upgrade()
    {

        if(level == 2)
        {
            Upgrade2Lvl2();
        }
        if(level == 3)
        {
            Upgrade2Lvl3();
        }
    }


    public void Upgrade2Lvl2()
    {
        rateOfFire = 0.3f;
        upgradeCost = 200;
        CircleCollider2D myCircleCollider = GetComponent<CircleCollider2D>();
        myCircleCollider.radius = 2.8f;
        Renderer rend = GetComponent<Renderer>();
        Material mat = rend.material;
        mat.color = Level2Colour;
    }

        public void Upgrade2Lvl3()
    {
        rateOfFire = 0.2f;
        upgradeCost = 500;
        CircleCollider2D myCircleCollider = GetComponent<CircleCollider2D>();
        myCircleCollider.radius = 3.2f;
        Renderer rend = GetComponent<Renderer>();
        Material mat = rend.material;
        mat.color = Level3Colour;
    }

    IEnumerator Shoot()
    {
        while(true)
        {
            if (TargetMode == true)
            {
                if(nearestAttacker != null)
                {
                    Quaternion extraAngleQ = Quaternion.Euler(0f, 0f, extraAngle);
                    TurnAngle = TurnAngle * extraAngleQ;
                    
                    GameObject bullet = Instantiate(Bullet, transform.position, TurnAngle);
                    //yield return new WaitForSeconds(BulletTime);
                    //nearestAttacker.health = nearestAttacker.health - 1;

                    if (nearestAttacker.health == 0)
                    {
                        RemoveAttackerFromList(nearestAttacker);
                    }
                    //yield return new WaitForSeconds(rateOfFire);
                }
                yield return new WaitForSeconds(rateOfFire);
            }
            if (TargetMode == false)
            {
                if(HighestHPAttacker != null)
                {
                    Quaternion extraAngleQ = Quaternion.Euler(0f, 0f, extraAngle);
                    TurnAngle = TurnAngleHP * extraAngleQ;
                    
                    GameObject bullet = Instantiate(Bullet, transform.position, TurnAngle);
                    //yield return new WaitForSeconds(BulletTime);
                    //nearestAttacker.health = nearestAttacker.health - 1;

                    if (HighestHPAttacker.health == 0)
                    {
                        RemoveAttackerFromList(HighestHPAttacker);
                        HighestHealth = 0;
                    }
                    //yield return new WaitForSeconds(rateOfFire);
                }
                yield return new WaitForSeconds(rateOfFire);
            }

 
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("collision detected");
            
            if (other.CompareTag("Attackers"))
            {
                Attacker atk = other.gameObject.GetComponent<Attacker>();
                allAttackers.Add(atk);
            }
            //GameObject atk = GameObject.FindWithTag("Attackers");
            
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Attacker exitedAttacker = other.gameObject.GetComponent<Attacker>();
        RemoveAttackerFromList(exitedAttacker);
    }
    private void RemoveAttackerFromList(Attacker Attacker)
    {
        if (allAttackers.Contains(Attacker))
        {
            allAttackers.Remove(Attacker);
            HighestHealth = 0;
        }
    
    }
}
