using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShopKeeper : MonoBehaviour
{
   public Button Button1;
   
   public GameObject Dialogue;

   public Animator CameraAnim;
   


    
    void Start()
    {
        Button1.interactable = false;
    }

   
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Dialogue.SetActive(true);
            Button1.interactable = true;

            FindObjectOfType<DialogueManager>().ResetDialog();

        }
    }

    void OnTriggerExit(Collider other)
    {
        Dialogue.SetActive(false);

        CameraAnim.SetTrigger("Camera1");
    }
}
