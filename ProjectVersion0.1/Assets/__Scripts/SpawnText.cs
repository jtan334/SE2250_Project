using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpawnText : MonoBehaviour {
    
   
    public GameObject dialogText;
    public bool playerInRange;
 
 
    
   public void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            playerInRange= true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            playerInRange=false;
            dialogText.SetActive(false);
        }
    }

    void Update(){
        if(playerInRange){
            dialogText.SetActive(true);
        }else{
            dialogText.SetActive(false);
            
        }

    }
}