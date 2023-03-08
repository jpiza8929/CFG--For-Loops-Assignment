using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawn : MonoBehaviour
{
    public GameObject apple;
    public int objnum;
    
    public Transform leftTop;
    public Transform Bttmright;

    // Start is called before the first frame update
    void Start()
    {
      for(int i = 0; i<20; i++)
      
      {
        float newX = Random.Range(leftTop.position.x, Bttmright.position.x);
        float newZ = Random.Range(Bttmright.position.z, leftTop.position.z);
        Vector3 newpos = new Vector3(newX, transform.position.y, newZ);
        GameObject newobj = Instantiate(apple, newpos, Quaternion.identity);
      }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
