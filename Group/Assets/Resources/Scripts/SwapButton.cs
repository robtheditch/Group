using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SwapButton : MonoBehaviour
{
    private GameObject m_gameobject;
    public InventoryoObject m_inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Testing(GameObject game)
    {
        m_gameobject = game;
      //  Debug.Log("swap has recevied"+ m_gameobject);
    }

    public void Swapping()
    {
         var obj = m_gameobject.GetComponent<item>();
           Debug.Log("fiddlesticks"+obj);
           m_inventory.SpawnObject(obj.m_item);
           m_gameobject.SendMessage("Delete");
       
    }
    public void Move()
    {
        this.transform.position = new Vector3(-500, 60, 60);
    }
    public void Testingbutton(GameObject button)
    { 
    
    }
    void Delete()
    {
        Destroy(this.gameObject);
    }
}
