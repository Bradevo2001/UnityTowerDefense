using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public Defender1 Defender1;
    public Defender2 Defender2;

    public Defender3 Defender3;

    public Defender4 Defender4;
    Economy Eco;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        Defender1 = hit.transform.gameObject.GetComponent<Defender1>();
        Defender2 = hit.transform.gameObject.GetComponent<Defender2>();
        Defender3 = hit.transform.gameObject.GetComponent<Defender3>();
        Defender4 = hit.transform.gameObject.GetComponent<Defender4>();
        Eco = GameObject.FindWithTag("ECO").GetComponent<Economy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            
 
 
                if(hit.collider != null && hit.transform.gameObject.name == "UpgradeButton")
                {
                    if(Defender1 != null && Eco.money > Defender1.upgradeCost)
                    {
                        Defender1.level++;
                        Eco.money = Eco.money - Defender1.upgradeCost;
                        Defender1.Upgrade();
                        if (Eco.money < Defender1.upgradeCost)
                        {
                            Debug.Log("not enough money");
                        }
                    }
                    else if(Defender2 != null && Eco.money > Defender2.upgradeCost)
                    {
                        Debug.Log("upgraded tower");
                        Defender2.level++;
                        Eco.money = Eco.money - Defender2.upgradeCost;
                        Defender2.Upgrade();
                        if (Eco.money < Defender2.upgradeCost)
                        {
                            Debug.Log("not enough money");
                        }
                    }  

                    else if(Defender3 != null && Eco.money > Defender3.upgradeCost)
                    {
                        Debug.Log("upgraded tower");
                        Defender3.level++;
                        Eco.money = Eco.money - Defender3.upgradeCost;
                        Defender3.Upgrade();
                        if (Eco.money < Defender3.upgradeCost)
                        {
                            Debug.Log("not enough money");
                        }
                    }   

                    else if(Defender4 != null && Eco.money > Defender4.upgradeCost)
                    {
                        Debug.Log("upgraded tower");
                        Defender4.level++;
                        Eco.money = Eco.money - Defender4.upgradeCost;
                        Defender4.Upgrade();
                        if (Eco.money < Defender4.upgradeCost)
                        {
                            Debug.Log("not enough money");
                        }
                    }                      

                }
 
        }
    }
}
