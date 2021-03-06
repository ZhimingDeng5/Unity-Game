using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Cursor.lockState == CursorLockMode.Locked){
                Cursor.lockState = CursorLockMode.None;
            }
            else{
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }
}
