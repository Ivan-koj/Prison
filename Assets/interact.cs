using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class interact : MonoBehaviour
{
    public Animator anim;
    public int otvoreno;
    public Transform blockPosition;
    public Transform blockPlayer;
    public Transform cam;
    public Rigidbody block;
    public BoxCollider block1;
    //UI
    public Image npcTalk;
    public Image inventori;
    public Image item1;
    //Inventori
    public bool activeINV=false;
    public float playerActiveDistance;
    private int broj;
    public int objectactive1=1;
    
    private bool active = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    IEnumerator NpcT()
    {
        npcTalk.gameObject.SetActive(true);
        yield return new WaitForSeconds(2);
        npcTalk.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActiveDistance);
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (hit.transform.tag == "Cube" && active == true)
            {
                blockPosition.position = blockPlayer.position;
                blockPosition.SetParent(blockPlayer);
                blockPosition.SetPositionAndRotation(blockPlayer.position, blockPlayer.rotation);
                block.freezeRotation = true;
                block1.isTrigger = true;
                blockPosition.rotation = default;
                broj = 1;
            }
            else
            {
              
            }

            if (hit.transform.tag == "npc")
            {
                StartCoroutine(NpcT());
            }
            if (hit.transform.tag == "vrata")
            {
                if (otvoreno == 1)
                {
                    otvoreno = 0;
                    anim.SetBool("Active", false);
                    
                }
                else
                {
                    otvoreno = 1;
                    anim.SetBool("Active", true);
                    
                }
                
            }

        }
        else
        {
            Debug.Log("No item with a tag");
        }
        
        if (Input.GetKey(KeyCode.Q))
        {

            blockPlayer.DetachChildren();
            
            block.freezeRotation = false;
            block1.isTrigger = false;
            blockPosition.rotation = default;
            broj = 0;
        }
        if (broj == 1)
        {
            blockPosition.position = blockPlayer.position;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
           Inventar();
        }

        InventarItemGrab();

    }

    public void Inventar()
    {
        if (activeINV == false)
        {
            inventori.gameObject.SetActive(true);
            activeINV = true;
            if (blockPlayer.transform.childCount == 1)
            {
                item1.gameObject.SetActive(true);
            }
            else
            {
                item1.gameObject.SetActive(false);
            }
        }
        else
        {
            inventori.gameObject.SetActive(false);
            activeINV = false;
            item1.gameObject.SetActive(false);
        }
        
    }

    public void InventarItemGrab()
    {
        
        if (activeINV == true)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (objectactive1 == 1)
                {
                    blockPosition.gameObject.SetActive(false);
                    objectactive1 = 0;
                }
                else
                {
                    blockPosition.gameObject.SetActive(true);
                    objectactive1 = 1;
                }
                
            }
            
            
        }
    }

    
}
