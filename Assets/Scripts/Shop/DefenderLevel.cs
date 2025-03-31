using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DefenderLevel : MonoBehaviour
{
    public Defender Defender;
    public GameObject Parent;
    TowerInfo parentScript;
    public int level;
    [SerializeField] private TextMeshPro levelText;
    // Start is called before the first frame update
    void Start()
    {
        
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        Defender = hit.transform.gameObject.GetComponent<Defender>();
        parentScript = Parent.GetComponent<TowerInfo>();
        levelText.text = "0";
        //Defender = parentScript.gameObject.GetComponent<Defender>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //if (Defender != null)
        //{
            //Defender = transform.parent.gameObject.Defender;
            
            level = Defender.level;
            levelText.text = level.ToString();
        //}
    }
}
