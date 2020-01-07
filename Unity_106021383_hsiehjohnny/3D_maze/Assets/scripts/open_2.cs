using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_2 : MonoBehaviour
{
    public Transform door2;
    public int hight = 7;
    private void Update()
    {

        door2.transform.position = new Vector3(door2.transform.position.x, 8.1f + Mathf.PingPong(Time.time * 7, hight), door2.transform.position.z);
    }
}
