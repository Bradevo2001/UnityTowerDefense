using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColor : MonoBehaviour
{
    private TextMeshPro textMeshPro;
    public TMP_FontAsset redFont;
    public TMP_FontAsset blackFont;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshPro>();



        if (textMeshPro != null)
        {
            // Get the Material associated with the TextMeshPro component

            // Set the initial color (optional)
            textMeshPro.font = blackFont;
        }
        else{
    Debug.LogError("TextMaterial component not found on this GameObject.");
        }

        
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        Debug.Log("Mouse entered!");
        textMeshPro.font = redFont;
    }
    void OnMouseExit()
    {
        Debug.Log("Mouse exited!");

        textMeshPro.font = blackFont;
    }
}
