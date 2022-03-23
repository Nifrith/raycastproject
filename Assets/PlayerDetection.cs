using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;

     void FixedUpdate()
    {
        HideTreasure();// Bit shift the index of the layer (8) to get a bit mask
       
    }

   void HideTreasure(){
        RaycastHit hit;
        Ray ray = new Ray(transform.position, target.position - transform.position);
           
        if(Physics.Raycast(ray, out hit, 3)){
          Debug.Log(hit.transform.gameObject.tag);
          if(hit.transform.gameObject.tag == "Player"){
               this.gameObject.SetActive(false);
          }
      }
      }
}

