using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public InputField answer;
    public string actualAns;
    public GameObject door;
    public GameObject key;
   
    public GameObject door2img;
    [SerializeField] private Animator MyAnimationController;

   
    public void onSubmit()
    {
        if(answer.text.ToUpper() == actualAns.ToUpper())
        {
            door.SetActive(false);
            door2img.SetActive(false);
            Debug.Log("You did it!");
            MyAnimationController.SetBool("open", true);
            key.SetActive(false);
           

        }
        else
            Debug.Log(answer.text);
    }
   
    

       // if (collider.gameObject.name == "Player")
        
    
}
