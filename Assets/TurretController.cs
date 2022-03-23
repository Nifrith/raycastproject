using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform character;
    public ParticleSystem shootEffect;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Shoot();
    }

    void Shoot(){
        shootEffect.Play();
        RaycastHit hit;
        Ray ray = new Ray(transform.position, character.position - transform.position);
           
        if(Physics.Raycast(ray, out hit, 20)){
          Debug.Log(hit.transform.gameObject.tag);
          if(hit.transform.tag == "Player"){
              Debug.Log("Torreta ha disparado al jugador");
              Rigidbody rb = hit.rigidbody;

              rb.AddForce(Vector3.right / 30, ForceMode.Impulse);
          }
      }
      }
}
