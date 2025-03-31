using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveDisplay : MonoBehaviour
{
    public int WaveRound = 0;
    [SerializeField] private TextMeshPro waveText;
    // Start is called before the first frame update
    void Start()
    {
        waveText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = WaveRound.ToString();
    }
}
