using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckPointManager GM;

    private void Awake()
    {
        GM = GameObject.FindGameObjectWithTag("GM").GetComponent<CheckPointManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Black"))
        {
            GM.LastCheckPoint = transform.position;
        }
    }
}
