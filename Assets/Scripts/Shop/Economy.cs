using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Economy : MonoBehaviour
{
    public bool upgradeMenu = false;
    public float money = 1300;
    public float GameHealth = 100;

    public string Menu;

    //public TowerInfo towerInfo;
    //public string moneyT = "100";
    [SerializeField] private TextMeshPro moneyText;
    [SerializeField] private TextMeshPro HPText;
    // Start is called before the first frame update
    void Start()
    {
        moneyText.text = "200";
        HPText.text = "100";
        
    }

    // Update is called once per frame
    void Update()
    {
        //moneyT = money.ToString();
        moneyText.text = money.ToString();
        HPText.text = GameHealth.ToString();
        if (GameHealth == 0)
        {
            SceneManager.LoadScene(Menu);
        }
    }
}
