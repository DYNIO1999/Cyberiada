using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockToDestroy : MonoBehaviour
{
    [SerializeField]
    private float endTime;
    private float timer;

    private bool isDestroyed;
    void Start()
    {
        isDestroyed = false;
        timer =0;
    }

    void Update()
    {
        if(isDestroyed){
        timer=timer+Time.deltaTime;
        if (timer > endTime){
            Object.Destroy(gameObject);
        }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            isDestroyed = true;
        }
    }
}
