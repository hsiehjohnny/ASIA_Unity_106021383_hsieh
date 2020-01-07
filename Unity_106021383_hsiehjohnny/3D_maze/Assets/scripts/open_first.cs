using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_first : MonoBehaviour
{
    public Transform door1;
    public int hight = 7; 

    private void Update()
    {
       
        door1.transform.position = new Vector3(door1.transform.position.x,8.1f + Mathf.PingPong(Time.time * 5, hight), door1.transform.position.z);
    }
    
}
