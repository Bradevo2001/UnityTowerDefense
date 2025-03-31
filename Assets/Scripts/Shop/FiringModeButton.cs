using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FiringModeButton : MonoBehaviour
{

    public Defender1 Defender1;
    public Defender2 Defender2;

    public Defender3 Defender3;

    public Defender4 Defender4;


    public Defender Defender;
    public GameObject Parent;
    TowerInfo parentScript;
    [SerializeField] private TextMeshPro FiringModeText;

    public bool Mode;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        Defender = hit.transform.gameObject.GetComponent<Defender>();
        parentScript = Parent.GetComponent<TowerInfo>();
        Defender1 = hit.transform.gameObject.GetComponent<Defender1>();
        Defender2 = hit.transform.gameObject.GetComponent<Defender2>();
        Defender3 = hit.transform.gameObject.GetComponent<Defender3>();
        Defender4 = hit.transform.gameObject.GetComponent<Defender4>();
        if (Defender.TargetMode ==  true)
        {
            FiringModeText.text = "FiringMode: Nearest";
            Debug.Log("first time");
        
        }
        else if (Defender.TargetMode ==  true)
        {
            FiringModeText.text = "FiringMode: Highest HP";
            Debug.Log("second time");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Mode = Defender.TargetMode;
        if (Mode == true)
        {
            FiringModeText.text = "FiringMode: Nearest";
            Debug.Log("first time");
        
        }
        else if (Mode == true)
        {
            FiringModeText.text = "FiringMode: Highest HP";
            Debug.Log("second time");
        }
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            
 
 
                if(hit.collider != null && hit.transform.gameObject.name == "FiringModeButton")
                {
                    if(Defender1 != null)
                    {
                        Defender1.ChangeFiringMode();
                        if (Defender.TargetMode ==  true)
                        {
                            FiringModeText.text = "FiringMode: Nearest";
                        }
                        else if (Defender.TargetMode ==  false)
                        {
                            FiringModeText.text = "FiringMode: Highest HP";
                        }
                    }
                    else if(Defender2 != null)
                    {
                           Defender2.ChangeFiringMode();
                        if (Defender.TargetMode ==  true)
                        {
                            FiringModeText.text = "FiringMode: Nearest";
                        }
                        else if (Defender.TargetMode ==  false)
                        {
                            FiringModeText.text = "FiringMode: Highest HP";
                        }
                    }  

                    else if(Defender3 != null)
                    {
                        Defender3.ChangeFiringMode();
                        if (Defender.TargetMode ==  true)
                        {
                            FiringModeText.text = "FiringMode: Nearest";
                        }
                        else if (Defender.TargetMode ==  false)
                        {
                            FiringModeText.text = "FiringMode: Highest HP";
                        }
                    }   

                    else if(Defender4 != null)
                    {
                        Defender4.ChangeFiringMode();
                        if (Defender.TargetMode ==  true)
                        {
                            FiringModeText.text = "FiringMode: Nearest";
                        }
                        else if (Defender.TargetMode ==  false)
                        {
                            FiringModeText.text = "FiringMode: Highest HP";
                        }
                    }   

                }
 
        }
    }
}
