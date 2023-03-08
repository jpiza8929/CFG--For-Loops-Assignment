using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
   //this variable is used for the ui to count the number of apples//
    int apples = 0;
    float time = 60;

    public GameObject gameover;
    
   
   //movement speed//
   public float speed = 5f;

   public TMP_Text applecllect, timer, GameOver;
   
   
    // Start is called before the first frame update
    void Start()
    {
       applecllect.text = apples.ToString();
       timer.text = time.ToString();
       time = 60;

       gameover = GameObject.Find("GameOver (TMP)");

       gameover.SetActive(false);
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentpos = transform.position;
        
        //x movement//

        if(Input.GetKey(KeyCode.S))
        {
          currentpos.z = currentpos.z + speed * Time.deltaTime;
        }
       
       if(Input.GetKey(KeyCode.W)){

         currentpos.z = currentpos.z - speed * Time.deltaTime;
    
        }

        //Z movement//
        if(Input.GetKey(KeyCode.A)){
    
         currentpos.x = currentpos.x + speed * Time.deltaTime;
    
        }

        if(Input.GetKey(KeyCode.D)){
    
        currentpos.x = currentpos.x - speed * Time.deltaTime;
        
        }
        
        transform.position = currentpos;

        time -= Time.deltaTime;
        int timeInt = Mathf.RoundToInt(time);
        timer.text = timeInt.ToString();

        if(time <= 0)
        {
            time = 0;
            speed = 0;

            gameover.SetActive(true);


        }
        
    }

    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Collectible")
        {
            apples++;
            applecllect.text = apples.ToString();
            Destroy(other.gameObject);
        }
    }

}

