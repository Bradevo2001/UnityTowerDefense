using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret3 : MonoBehaviour
{
    public GameObject turret3Prefab;
    public GameObject turret;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //RaycastHit hit;
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            
            //if (Physics2D.Raycast(ray, out hit))
            //{
                if(hit.collider != null && hit.transform.gameObject.name == "Turret3")
                {
                    turret = Instantiate(turret3Prefab, Input.mousePosition, transform.rotation);
            
                    Debug.Log("spawned turret");
                    //turret.PlacedDown = false;
                }
            //}
        }
        
    }
}