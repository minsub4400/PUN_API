using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQueue : MonoBehaviour
{
    public Queue queue = new Queue();
    private void Awake()
    {
        queue.Enqueue(-1);
    }


    void Start()
    {
        
    }

}
