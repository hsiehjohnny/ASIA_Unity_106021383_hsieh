using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    private Transform trapa;
    public float hight = 5;//距離
    public float starpoint = 12.5f; //起點

    void Start()
    {
       
     trapa = this.transform.Find("trap"); 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(starpoint - Mathf.PingPong(Time.time * 5, hight),  
                                         transform.position.y,                              
                                         transform.position.z);
    }
}
