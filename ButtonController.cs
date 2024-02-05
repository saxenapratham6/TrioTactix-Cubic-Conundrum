using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    

    
    [SerializeField] private TicTacToeController tCont;

    public string parentName;

    public bool completesGame;

    public bool isX;
    public bool isO;

    // Start is called before the first frame update
    void Start()
    {
        parentName = this.transform.parent.name;
        completesGame = false;
        isX = false;
        isO = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnButtonClick()
    {



        

        if (tCont.turn == 0)
        {

            if (parentName == tCont.currentZone || tCont.zoneConflict)
            {

                this.gameObject.GetComponent<Image>().sprite = tCont.xImage;
                isX = true;
                this.gameObject.GetComponent<Button>().interactable = false;
                tCont.turn = 1;
                tCont.currentZone = this.gameObject.name;
                tCont.currentZone = this.gameObject.name;

            }

        }
        else
        {



            if (parentName == tCont.currentZone || tCont.zoneConflict)
            {
                this.gameObject.GetComponent<Image>().sprite = tCont.oImage;
                isO = true;
                this.gameObject.GetComponent<Button>().interactable = false;
                tCont.turn = 0;
                tCont.currentZone = this.gameObject.name;
                tCont.currentZone = this.gameObject.name;
            } 
           
            

        }

        

        

        
    }
}
