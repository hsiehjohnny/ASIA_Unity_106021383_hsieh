using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapu5 : MonoBehaviour
{
    private Transform trapa;
    public float hight = 5;//距離
    public float starpoint = 7.3f; //起點

    void Start()
    {

        trapa = this.transform.Find("trapu4");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x,  
                                         starpoint + Mathf.PingPong(Time.time * 3, hight),
                                         
                                         transform.position.z);
    }
}
