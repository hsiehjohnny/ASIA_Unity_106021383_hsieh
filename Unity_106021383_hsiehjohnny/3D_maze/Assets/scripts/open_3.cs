using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_3 : MonoBehaviour
{
    public Transform door3;
    public int hight = 7;
    private void Update()
    {

        door3.transform.position = new Vector3(door3.transform.position.x, 8.1f + Mathf.PingPong(Time.time * 10, hight), door3.transform.position.z);
    }
}
