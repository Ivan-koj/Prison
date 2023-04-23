using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public Transform Player;
    public GameObject player, teleport;
    public Transform tp1, tp2;
    private float telp;
    public Transform cam;
    public float playerActiveDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActiveDistance);
        if (Input.GetKeyDown(KeyCode.F))
        {
           
            if (hit.transform.tag == "Teleport")
            {
               StartCoroutine(Teleport2());
            }
            
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (teleport.activeSelf)
            {
                StartCoroutine(Teleport1());
                teleport.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (teleport.activeSelf)
            {
                teleport.SetActive(false);
            }
        }
       
    }

    IEnumerator Teleport2()
    {
        teleport.SetActive(true);
        yield return new WaitForSeconds(4);
        teleport.SetActive(false);
    }
    IEnumerator  Teleport1()
    {
        yield return new WaitForSeconds(1);
        if (telp == 0)
        {
            player.SetActive(false);
            Player.transform.position = new Vector3(tp1.transform.position.x,tp1.transform.position.y,tp1.transform.position.z);
            player.SetActive(true);
            telp = 1;
        }
        else
        {
            player.SetActive(false);
            Player.transform.position = new Vector3(tp2.transform.position.x,tp2.transform.position.y,tp2.transform.position.z);
            player.SetActive(true);
            telp = 0;
        }
    }
}
