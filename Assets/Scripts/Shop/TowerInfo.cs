using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerInfo : MonoBehaviour
{
    //public bool visable = false;
    Vector2 UpgradeMenuPos;
    public Defender Defender;
    // Start is called before the first frame update
    void Start()
    {
        UpgradeMenuPos = new Vector2(8.3521f, 1.0456f);
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        Defender = hit.transform.gameObject.GetComponent<Defender>();
    }

    // Update is called once per frame
    void Update()
    { 

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Destroy(gameObject);
        }
        if (Input.GetMouseButtonDown(0))
        {
            //RaycastHit hit;
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            
            
            //if (Physics2D.Raycast(ray, out hit))
            //{
                //foreach(RaycastHit2D hit in hits)
                //{
                    
                    //Debug.Log(hit.transform.gameObject.name);
                if(hit.collider != null && hit.transform.gameObject.name == "Defender1(Clone)")
                {
                    Defender = hit.transform.gameObject.GetComponent<Defender>(); 
                    //Quaternion.Euler(new Vector3(0, 0, 0))
                    //turret.PlacedDown = false;
                }
                else if(hit.collider != null && hit.transform.gameObject.name == "Defender2(Clone)")
                {
                    Defender = hit.transform.gameObject.GetComponent<Defender>(); 
                    //Quaternion.Euler(new Vector3(0, 0, 0))
                    //turret.PlacedDown = false;
                }

                else if(hit.collider != null && hit.transform.gameObject.name == "Defender3(Clone)")
                {
                    Defender = hit.transform.gameObject.GetComponent<Defender>(); 
                    //Quaternion.Euler(new Vector3(0, 0, 0))
                    //turret.PlacedDown = false;
                }
                else if(hit.collider != null && hit.transform.gameObject.name == "Defender4(Clone)")
                {
                    Defender = hit.transform.gameObject.GetComponent<Defender>(); 
                    //Quaternion.Euler(new Vector3(0, 0, 0))
                    //turret.PlacedDown = false;
                }
                //}
            //}
        }
        
    }


}
