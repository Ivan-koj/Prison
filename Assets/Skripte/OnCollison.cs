using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollison : MonoBehaviour
{
    public HealthBarControler healtbar;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "damage")
        {
            if (healtbar)
            {
                healtbar.onTakeDamage(10);
            }
        }
    }
}
