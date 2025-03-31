using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Def4PlaceDownAOE : MonoBehaviour
{

    public Economy Eco;
    public GameObject towerInfo;
    public GameObject UpgradeMenuPrefab;
    public GameObject UpgradeMenu;
    Vector2 UpgradeMenuPos;
    Defender4 Parent;
    public int CollisionCount = 0;
    //GameObject Parent = gameObject.parent;
    // Start is called before the first frame update
    void Start()
    {
        Eco = GameObject.FindWithTag("ECO").GetComponent<Economy>();
        UpgradeMenuPos = new Vector2(8.3521f, 1.0456f);
        Parent = transform.parent.GetComponent<Defender4>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

                if(hit.collider != null && hit.transform.gameObject.name == "Defender4(Clone)")
                {
                    if (Eco.upgradeMenu == false)
                    {
                        GameObject[] Menus = GameObject.FindGameObjectsWithTag("TowerInfo");
                        foreach (GameObject menu in Menus)
                            Destroy(menu);
                  if (Parent.placedDown == true){
                        UpgradeMenu = Instantiate(UpgradeMenuPrefab, UpgradeMenuPos, Quaternion.Euler(new Vector3(0, 0, 0)));
                        Eco.upgradeMenu = true;
                    }
                    }
                    else if (Eco.upgradeMenu == true)
                    {
                        GameObject[] Menus = GameObject.FindGameObjectsWithTag("TowerInfo");
                        foreach (GameObject menu in Menus)
                            Destroy(menu);
                    towerInfo = GameObject.FindWithTag("TowerInfo");
                    //.GetComponent<TowerInfo>();    
                    Destroy(towerInfo);
                  if (Parent.placedDown == true){
                        UpgradeMenu = Instantiate(UpgradeMenuPrefab, UpgradeMenuPos, Quaternion.Euler(new Vector3(0, 0, 0)));
                        Eco.upgradeMenu = true;
                    }
                    }

                }

        }
        if(CollisionCount > 0)
        {
            Parent.canPlaceDown = false;
        }
        else if(CollisionCount == 0)
        {
            Parent.canPlaceDown = true;
        }
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
         //Debug.Log("collision detected with " + col.gameObject.tag);
        if(col.gameObject.tag == "DefenderAOE")
        {
            Debug.Log("cant place down");
            //Parent.canPlaceDown == false;
            //Parent.canPlaceDown = false;
            CollisionCount++;
            //Destroy(gameObject);

        }
        if(col.gameObject.tag == "Path")
        {
            Debug.Log("cant place down");
            //Parent.canPlaceDown == false;
            //Parent.canPlaceDown = false;
            CollisionCount++;
            //Destroy(gameObject);

        }

    }

    public void OnTriggerExit2D(Collider2D col)
    {
         //Debug.Log("collision detected with " + col.gameObject.tag);
        if(col.gameObject.tag == "DefenderAOE")
        {
            Debug.Log("can place down");
            //Parent.canPlaceDown = true;
            CollisionCount--;
            //Destroy(gameObject);

        }
        if(col.gameObject.tag == "Path")
        {
            Debug.Log("can place down");
            //Parent.canPlaceDown = true;
            CollisionCount--;
            //Destroy(gameObject);

        }
        

    }
}
