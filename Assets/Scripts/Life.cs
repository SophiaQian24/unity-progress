using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Life : MonoBehaviour
{
    public float amount = 100f;
    public UnityEvent onDeath;

    // Update is called once per frame
    void Die()
    {
        if(amount<=0)
        {
            onDeath.Invoke();
            Destroy(gameObject);
        }
        
    }
}
