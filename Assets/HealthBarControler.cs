using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarControler : MonoBehaviour
{
    public float health;

    public Image healtbar;

    public float startHealth;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    public void onTakeDamage(int damage)
    {
        health = health - damage;
        healtbar.fillAmount = health / startHealth;
    }
}
