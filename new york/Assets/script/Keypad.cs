using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;


public class Keypad : MonoBehaviour
{

    public string curPassword = "042";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform doorHinge;
    public MouseLook mouseLook;
    public AudioSource doorsound;

    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
        mouseLook.enabled = true;
        HideCursor();

    }

    void Update()
    {
        if (input == curPassword)
        {
            doorsound.Play();
            doorOpen = true;
            mouseLook.enabled = true;
            HideCursor();
        }
        

        if (doorOpen)
        {
            
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
            

        }
    }
    public void ShowCursor()
    {


        
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideCursor()
    {

        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
   
 

    void OnGUI()
    {
        if (!doorOpen)
        {
            if (onTrigger)
            {
               
              /*
                GUIStyle guiStyle = new GUIStyle(GUI.skin.label);
                guiStyle.normal.textColor = Color.white;
                guiStyle.fontSize = 36;
                guiStyle.alignment = TextAnchor.MiddleCenter;
                Font myFont = (Font)Resources.Load("Fonts/AMERICANCAPTAINWEBFONT", typeof(Font));
                guiStyle.font = myFont;
                GUI.Label(new Rect(0, 0, 300, 100), "Press 'E' to open keypad", guiStyle);
                if (Keyboard.current[Key.E].wasPressedThisFrame)
              */

                {
                    keypadScreen = true;
                    onTrigger = false;
                }
            }

            if (keypadScreen)
            {
                ShowCursor();
                mouseLook.enabled = false;
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    HideCursor();
                }

                GUI.skin.box.normal.textColor = Color.cyan;
                GUI.backgroundColor = Color.cyan;
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect(5, 5, 310, 25), input);

                if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
                {
                    input = input + "1";
                }

                if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
                {
                    input = input + "2";
                }

                if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
                {
                    input = input + "3";
                }

                if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
                {
                    input = input + "4";
                }

                if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
                {
                    input = input + "5";
                }

                if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
                {
                    input = input + "6";
                }

                if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
                {
                    input = input + "7";
                }

                if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
                {
                    input = input + "8";
                }

                if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
                {
                    input = input + "9";
                }

                if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
                {
                    input = input + "0";
                }

                if (Keyboard.current[Key.Escape].wasPressedThisFrame)
                {

                    keypadScreen = false;
                }

            }
        }
    }

   
}

