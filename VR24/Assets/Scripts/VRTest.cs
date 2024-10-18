using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VRTest : MonoBehaviour
{
    public GameObject Test;
    public int x = 0;
    public Text Mytxt;
    public int z, y, c;
    public float[] numbers;

    // Start is called before the first frame update
    void Start()
    {
        numbers = new float[] { 1, 2, 5, 6, 7 };
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //x++;
        if(x >= 150)
        {
            Test.SetActive(false);
        }
        string v =  x.ToString();
        Mytxt.text = v;
    }

    public void ClickBut()
    {
        z = UnityEngine.Random.Range(0, 255);
        y = UnityEngine.Random.Range(0, 255);
        c = UnityEngine.Random.Range(0, 255);
        GetComponent<Renderer>().material.color = new Color32((byte)z, (byte)y, (byte)c, 1);
        Debug.Log(numbers[2]);
    }
}
