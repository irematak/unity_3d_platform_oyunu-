using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    [SerializeField] float speed;
    float startSpeed;

    Vector3 direction;
    
    [SerializeField] Rigidbody rb;
    #endregion

    private void Start()
    {
        startSpeed = speed;
    }

    void Update()
    {
        if (speed < startSpeed) speed += Time.deltaTime;

        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));        
        if(direction.z < .0f == false) transform.Translate(direction * speed * Time.deltaTime);

        #region Henuz Kullanilmiyor
        float zipla = Input.GetAxis("Jump");

        if (Input.GetAxis("Jump") > 0)
        {
            rb.velocity = new Vector3(0, 5, 0);
        }

        //dýþýna taþarsa
        if (transform.position.x > 7.0f)
        {
            transform.position = new Vector3(0.0f, 0.32f, 0.0f); // geriye gidiyor dönüp benimki sifýr burda sorun yokk
        }
        else if (transform.position.x < -7.0f)
        {
            transform.position = new Vector3(0.0f, 0.32f, 0.0f);
        }
        #endregion
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("blok"))
        {
            transform.position -= Vector3.forward;
            speed *= .5f;
        }        
    }
}
