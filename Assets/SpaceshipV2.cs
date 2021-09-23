using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipV2 : MonoBehaviour
{

    public float speedShip = 1f;
    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * speedShip * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speedShip * Time.deltaTime;

        transform.Translate(horizontal, vertical,0);
    }

}
