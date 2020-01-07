using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outdoor : MonoBehaviour
{
    private string name = "監牢出口";
    private string content = "請找到兩個寶箱裡的鑰匙碎片";

    [Header("對話")]
    public DialogSystem ds;



    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player") 
        {
            ds.showdialog(content);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ds.hidedialog();
    }



}
