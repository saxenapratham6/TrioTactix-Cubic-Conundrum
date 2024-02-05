using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinChecker : MonoBehaviour
{

    [SerializeField] private List<GameObject> squares;

    [SerializeField] private GameObject bigImage;
    [SerializeField] private TicTacToeController tCont;

    public bool test;


    public bool zoneDone;

    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in transform)
        {
            squares.Add(child.gameObject);
        }

        zoneDone = false;
    }

    // Update is called once per frame
    void Update()
    {
        Checker();
       
       

       

    
    }


    void Checker()
    {
        //CHECKS IF HORIZONTALS ARE ALL O
        if (squares[0].GetComponent<ButtonController>().isO && squares[1].GetComponent<ButtonController>().isO && squares[2].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;
        }
        else if (squares[3].GetComponent<ButtonController>().isO && squares[4].GetComponent<ButtonController>().isO && squares[5].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[6].GetComponent<ButtonController>().isO && squares[7].GetComponent<ButtonController>().isO && squares[8].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        //CHECKS IF HORIZONTALS ARE ALL X
        else if (squares[0].GetComponent<ButtonController>().isX && squares[1].GetComponent<ButtonController>().isX && squares[2].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[3].GetComponent<ButtonController>().isX && squares[4].GetComponent<ButtonController>().isX && squares[5].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[6].GetComponent<ButtonController>().isX && squares[7].GetComponent<ButtonController>().isX && squares[8].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        //CHECKS IF VERTICALS ARE ALL X
        else if (squares[0].GetComponent<ButtonController>().isX && squares[3].GetComponent<ButtonController>().isX && squares[6].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[1].GetComponent<ButtonController>().isX && squares[4].GetComponent<ButtonController>().isX && squares[7].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[2].GetComponent<ButtonController>().isX && squares[5].GetComponent<ButtonController>().isX && squares[8].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        //CHECKS IF VERTICALS ARE O
        else if (squares[0].GetComponent<ButtonController>().isO && squares[3].GetComponent<ButtonController>().isO && squares[6].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[1].GetComponent<ButtonController>().isO && squares[4].GetComponent<ButtonController>().isO && squares[7].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[2].GetComponent<ButtonController>().isO && squares[5].GetComponent<ButtonController>().isO && squares[8].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        //CHECKS IF DIAGONALS ARE O
        else if (squares[0].GetComponent<ButtonController>().isO && squares[4].GetComponent<ButtonController>().isO && squares[8].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[6].GetComponent<ButtonController>().isO && squares[4].GetComponent<ButtonController>().isO && squares[2].GetComponent<ButtonController>().isO)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.oImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        //CHECKS IF DIAGONALS ARE X
        else if (squares[0].GetComponent<ButtonController>().isX && squares[4].GetComponent<ButtonController>().isX && squares[8].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
        else if (squares[6].GetComponent<ButtonController>().isX && squares[4].GetComponent<ButtonController>().isX && squares[2].GetComponent<ButtonController>().isX)
        {
            bigImage.gameObject.GetComponent<Image>().sprite = tCont.xImage;
            bigImage.SetActive(true);
            zoneDone = true;

        }
    }
}
