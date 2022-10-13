using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    public int PlayerNumber;
    public float moveSpeed;
    [SerializeField]
    Transform barrelRotator;
    [SerializeField]
    Transform firePoint;
    [SerializeField]
    GameObject bulletToFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      
        if (PlayerNumber == 1)
        {
              barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        }
        if (PlayerNumber == 2)
        {
            barrelRotator.RotateAround(Vector3.forward, Input.GetAxis("Vertical") * moveSpeed * -Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = Instantiate(bulletToFire, firePoint.position, firePoint.rotation);
            if (PlayerNumber == 1)
            {
                b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.right * 10, ForceMode2D.Impulse);
            }
            if (PlayerNumber == 2)
            {
                b.GetComponent<Rigidbody2D>().AddForce(barrelRotator.right * -10, ForceMode2D.Impulse);
            }
            
          
        }
        if (PlayerNumber == 1) { }

        transform.Translate(Vector2.right * Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);

    }
}
