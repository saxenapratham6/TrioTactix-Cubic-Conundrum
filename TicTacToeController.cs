using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeController : MonoBehaviour
{
    public int turn;
    public string currentZone;
    public string[] zones = { "tl","tm","tr", "ml", "mm", "mr", "bl", "bm", "br" };
    public bool zoneConflict;
    
    public Sprite xImage;
    public Sprite oImage;

    [SerializeField] private GameObject xText;
    [SerializeField] private GameObject oText;

    [SerializeField] private List<GameObject> highlights;
    [SerializeField] private List<GameObject> zoneList;
    public List<GameObject> bigImages;
    [SerializeField] private GameObject hugeHighlight;
   

    // Start is called before the first frame update
    void Start()
    {
        turn = 0;
        currentZone = zones[Random.Range(0, 8)];
    }

    // Update is called once per frame
    void Update()
    {

        
        
        //Debug.Log(currentZone);
        if(turn == 0)
        {
            xText.SetActive(true);
            oText.SetActive(false);
        }
        else
        {
            xText.SetActive(false);
            oText.SetActive(true);
        }




        foreach(GameObject highlight in highlights)
        {

            if(highlight.name == currentZone && !zoneConflict)
            {
                highlight.SetActive(true);
            }
            else
            {
                highlight.SetActive(false);
            }
        }

        if(zoneConflict)
        {
            hugeHighlight.SetActive(true);
        }
        else
        {
            hugeHighlight.SetActive(false);
        }

        


    }

   
}
