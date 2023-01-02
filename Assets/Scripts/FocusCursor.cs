using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//FocusCursor
public class FocusCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
