using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gate2 : MonoBehaviour
{

    public MouseLook mouseLook;
    [SerializeField]
    private GameObject Door1Img;
    
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            mouseLook.enabled = false;
            ShowCursor();
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                HideCursor();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            HideCursor();
        }
    }


    public void ShowCursor()
    {

        Door1Img.SetActive(true);

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideCursor()
    {

        Door1Img.SetActive(false);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}