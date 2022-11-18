using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavPlayer : MonoBehaviour
 {
    public GameObject Player;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Mouse X") * rotationSpeed;
        Player.transform.eulerAngles = new Vector3(0, Player.transform.eulerAngles.y + y, 0);

    }

}
