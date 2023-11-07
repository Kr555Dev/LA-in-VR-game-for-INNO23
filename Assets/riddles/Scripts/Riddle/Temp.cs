using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture[] index;
    void Start()
    {
        GameObject[] riddles = new GameObject[4];
        for (int i = 0; i < 4; i++)
        {
            riddles[i] = transform.GetChild(i).gameObject;
            riddles[i].GetComponent<Renderer>().material.SetTexture("_MainTex", index[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
