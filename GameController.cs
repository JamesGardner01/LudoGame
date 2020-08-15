using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Controllers/objects
    public bool gameOver;
    public GameObject endGame;
    public int players = 4;
    private int placement = 0;
    public TextMeshProUGUI placementText;
    

    public GameObject gameController;
    public GameObject[] boardPieces;
    public GameObject[] diceSides;

    public GameObject turnIndicatorBack;
    public GameObject redTurnIndicator;
    public GameObject greenTurnIndicator;
    public GameObject yellowTurnIndicator;
    public GameObject blueTurnIndicator;

    //RED VARIABLES
    private int redPieces;
    public GameObject redHolder;
    public string redColour = "Red";

    //Red Piece 1 Variables
    public bool redPiece1Exists;

    public GameObject redPiece1;
    public GameObject redPiece1Projection;

    public int redPiece1Location;
    private int redPiece1NewLocation;
    private bool redPiece1InHolder;
    private bool redPiece1Moveable;
    public GameObject redPiece1ProjectionParent;

    public bool redPiece1KnockOff = false;

    //Red Piece 2 Variables
    public bool redPiece2Exists;

    public GameObject redPiece2;
    public GameObject redPiece2Projection;

    public int redPiece2Location;
    private int redPiece2NewLocation;
    private bool redPiece2InHolder;
    private bool redPiece2Moveable;
    public GameObject redPiece2ProjectionParent;

    public bool redPiece2KnockOff = false;

    //Red Piece 3 Variables
    public bool redPiece3Exists;

    public GameObject redPiece3;
    public GameObject redPiece3Projection;

    public int redPiece3Location;
    private int redPiece3NewLocation;
    private bool redPiece3InHolder;
    private bool redPiece3Moveable;
    public GameObject redPiece3ProjectionParent;

    public bool redPiece3KnockOff = false;

    //Red Piece 4 Variables
    public bool redPiece4Exists;

    public GameObject redPiece4;
    public GameObject redPiece4Projection;

    public int redPiece4Location;
    private int redPiece4NewLocation;
    private bool redPiece4InHolder;
    private bool redPiece4Moveable;
    public GameObject redPiece4ProjectionParent;

    public bool redPiece4KnockOff = false;

    //GREEN VARIABLES
    private int greenPieces;
    public GameObject greenHolder;

    //Green Piece 1 Variables
    private bool greenPiece1Exists;

    public GameObject greenPiece1;

    private int greenPiece1Location;
    private int greenPiece1NewLocation;
    private bool greenPiece1InHolder;
    private bool greenPiece1Moveable;
    public GameObject greenPiece1ProjectionParent;

    private int greenPiece1Priority;
    private bool greenPiece1Chosen;

    //Green Piece 2 Variables
    private bool greenPiece2Exists;

    public GameObject greenPiece2;

    private int greenPiece2Location;
    private int greenPiece2NewLocation;
    private bool greenPiece2InHolder;
    private bool greenPiece2Moveable;
    public GameObject greenPiece2ProjectionParent;

    private int greenPiece2Priority;
    private bool greenPiece2Chosen;

    //Green Piece 3 Variables
    private bool greenPiece3Exists;

    public GameObject greenPiece3;

    private int greenPiece3Location;
    private int greenPiece3NewLocation;
    private bool greenPiece3InHolder;
    private bool greenPiece3Moveable;
    public GameObject greenPiece3ProjectionParent;

    private int greenPiece3Priority;
    private bool greenPiece3Chosen;

    //Green Piece 4 Variables
    private bool greenPiece4Exists;

    public GameObject greenPiece4;

    private int greenPiece4Location;
    private int greenPiece4NewLocation;
    private bool greenPiece4InHolder;
    private bool greenPiece4Moveable;
    public GameObject greenPiece4ProjectionParent;

    private int greenPiece4Priority;
    private bool greenPiece4Chosen;

    // YELLOW VARIABLES
    private int yellowPieces;
    public GameObject yellowHolder;

    //Yellow Piece 1 Variables
    private bool yellowPiece1Exists;

    public GameObject yellowPiece1;

    private int yellowPiece1Location;
    private int yellowPiece1NewLocation;
    private bool yellowPiece1InHolder;
    private bool yellowPiece1Moveable;
    public GameObject yellowPiece1ProjectionParent;

    private int yellowPiece1Priority;
    private bool yellowPiece1Chosen;

    //Yellow Piece 2 Variables
    private bool yellowPiece2Exists;

    public GameObject yellowPiece2;

    private int yellowPiece2Location;
    private int yellowPiece2NewLocation;
    private bool yellowPiece2InHolder;
    private bool yellowPiece2Moveable;
    public GameObject yellowPiece2ProjectionParent;

    private int yellowPiece2Priority;
    private bool yellowPiece2Chosen;

    //Yellow Piece 3 Variables
    private bool yellowPiece3Exists;

    public GameObject yellowPiece3;

    private int yellowPiece3Location;
    private int yellowPiece3NewLocation;
    private bool yellowPiece3InHolder;
    private bool yellowPiece3Moveable;
    public GameObject yellowPiece3ProjectionParent;

    private int yellowPiece3Priority;
    private bool yellowPiece3Chosen;

    //Yellow Piece 4 Variables
    private bool yellowPiece4Exists;

    public GameObject yellowPiece4;

    private int yellowPiece4Location;
    private int yellowPiece4NewLocation;
    private bool yellowPiece4InHolder;
    private bool yellowPiece4Moveable;
    public GameObject yellowPiece4ProjectionParent;

    private int yellowPiece4Priority;
    private bool yellowPiece4Chosen;

    //BLUE VARIABLES
    private int bluePieces;
    public GameObject blueHolder;

    //Blue Piece 1 Variables
    private bool bluePiece1Exists;

    public GameObject bluePiece1;

    private int bluePiece1Location;
    private int bluePiece1NewLocation;
    private bool bluePiece1InHolder;
    private bool bluePiece1Moveable;
    public GameObject bluePiece1ProjectionParent;

    private int bluePiece1Priority;
    private bool bluePiece1Chosen;

    //Blue Piece 2 Variables
    private bool bluePiece2Exists;

    public GameObject bluePiece2;

    private int bluePiece2Location;
    private int bluePiece2NewLocation;
    private bool bluePiece2InHolder;
    private bool bluePiece2Moveable;
    public GameObject bluePiece2ProjectionParent;

    private int bluePiece2Priority;
    private bool bluePiece2Chosen;

    //Blue Piece 3 Variables
    private bool bluePiece3Exists;

    public GameObject bluePiece3;

    private int bluePiece3Location;
    private int bluePiece3NewLocation;
    private bool bluePiece3InHolder;
    private bool bluePiece3Moveable;
    public GameObject bluePiece3ProjectionParent;

    private int bluePiece3Priority;
    private bool bluePiece3Chosen;

    //Blue Piece 4 Variables
    private bool bluePiece4Exists;

    public GameObject bluePiece4;

    private int bluePiece4Location;
    private int bluePiece4NewLocation;
    private bool bluePiece4InHolder;
    private bool bluePiece4Moveable;
    public GameObject bluePiece4ProjectionParent;

    private int bluePiece4Priority;
    private bool bluePiece4Chosen;


    //Dice/Turn variables
    private int diceNum;
    private bool newRoll;
    private bool rolled;
    public GameObject rollDiceButton;

    private bool moved;
    private bool pieceMoved;

    public GameObject check;

    public TextMeshProUGUI turnText;

    //BOARD MATERIALS
    public GameObject [] neutralBoard;
    public GameObject [] redBoard;
    public GameObject redArrowBoard;
    public GameObject [] greenBoard;
    public GameObject greenArrowBoard;
    public GameObject [] yellowBoard;
    public GameObject yellowArrowBoard;
    public GameObject [] blueBoard;
    public GameObject blueArrowBoard;

    public Material neutralBoardMaterial;
    public Material neutralBlockMaterial;

    public Material redBlockMaterial;
    public Material redBoardMaterial;
    public Material redArrowMaterial;

    public Material greenBlockMaterial;
    public Material greenBoardMaterial;
    public Material greenArrowMaterial;

    public Material yellowBlockMaterial;
    public Material yellowBoardMaterial;
    public Material yellowArrowMaterial;

    public Material blueBlockMaterial;
    public Material blueBoardMaterial;
    public Material blueArrowMaterial;

    void Start()
    {
        Time.timeScale = 1;

        boardPieces = GameObject.FindGameObjectsWithTag("BoardPiece");
        gameOver = false;

        turnIndicatorBack.SetActive(false);
        redTurnIndicator.SetActive(false);
        greenTurnIndicator.SetActive(false);
        yellowTurnIndicator.SetActive(false);
        blueTurnIndicator.SetActive(false);

        //RED PIECES
        redPiece1.transform.GetComponent<RedPiece1>().enabled = false;
        redPiece2.transform.GetComponent<RedPiece2>().enabled = false;
        redPiece3.transform.GetComponent<RedPiece3>().enabled = false;
        redPiece4.transform.GetComponent<RedPiece4>().enabled = false;

        redPieces = 4;

        redPiece1Exists = true;
        redPiece1InHolder = true;

        redPiece2Exists = true;
        redPiece2InHolder = true;

        redPiece3Exists = true;
        redPiece3InHolder = true;

        redPiece4Exists = true;
        redPiece4InHolder = true;

        //GREEN PIECES
        greenPieces = 4;

        greenPiece1Exists = true;
        greenPiece1InHolder = true;

        greenPiece2Exists = true;
        greenPiece2InHolder = true;

        greenPiece3Exists = true;
        greenPiece3InHolder = true;

        greenPiece4Exists = true;
        greenPiece4InHolder = true;

        //YELLOW PIECES
        yellowPieces = 4;

        yellowPiece1Exists = true;
        yellowPiece1InHolder = true;

        yellowPiece2Exists = true;
        yellowPiece2InHolder = true;

        yellowPiece3Exists = true;
        yellowPiece3InHolder = true;

        yellowPiece4Exists = true;
        yellowPiece4InHolder = true;

        //BLUE PIECES
        bluePieces = 4;

        bluePiece1Exists = true;
        bluePiece1InHolder = true;

        bluePiece2Exists = true;
        bluePiece2InHolder = true;

        bluePiece3Exists = true;
        bluePiece3InHolder = true;

        bluePiece4Exists = true;
        bluePiece4InHolder = true;

        diceNum = 1;
        newRoll = false;

        StartCoroutine(GameControl());
    }

    void Update()
    {
        if (redPieces < 1)
        {
            gameOver = true;
        }
        
        if (players < 2)
        {
            placement = 4;
            gameOver = true;
        }

        if (gameOver == true)
        {
            endGame.SetActive(true);
            Time.timeScale = 0;
            if (placement == 1)
            {
                placementText.GetComponent<TMPro.TextMeshProUGUI>().text = "YOU CAME 1ST";
            }
            
            else if (placement == 2)
            {
                placementText.GetComponent<TMPro.TextMeshProUGUI>().text = "YOU CAME 2ND";
            }

            else if (placement == 3)
            {
                placementText.GetComponent<TMPro.TextMeshProUGUI>().text = "YOU CAME 3RD";
            }
            
            else if (placement == 4)
            {
                placementText.GetComponent<TMPro.TextMeshProUGUI>().text = "YOU CAME 4TH";
            }
        }

        blockCheck();
    }

    //COROUTINE CONTROLS THE TURNS AND END GAME
    public IEnumerator GameControl()
    {
        while (gameOver == false)
        {
            Debug.Log("Red/Player turn");
            if (redPieces > 0)
            {
                turnIndicatorBack.SetActive(true);
                redTurnIndicator.SetActive(true);
                turnText.GetComponent<TMPro.TextMeshProUGUI>().text = "Red's Turn";

                yield return StartCoroutine(PlayerTurn());
                
                if (redPieces < 1)
                {
                    gameOver = true;
                }

                yield return Wait(1.25f);
                
                turnIndicatorBack.SetActive(false);
                redTurnIndicator.SetActive(false);
            }

            diceSides[diceNum - 1].SetActive(false);
            yield return Wait(0.75f);


            Debug.Log("Green turn");
            if (greenPieces > 0)
            {
                turnIndicatorBack.SetActive(true);
                greenTurnIndicator.SetActive(true);
                turnText.GetComponent<TMPro.TextMeshProUGUI>().text = "Green's Turn";

                yield return StartCoroutine(GreenTurn());

                yield return Wait(1.25f);

                turnIndicatorBack.SetActive(false);
                greenTurnIndicator.SetActive(false);
            }

            diceSides[diceNum - 1].SetActive(false);
            yield return Wait(0.75f);


            Debug.Log("Yellow turn");
            if (yellowPieces > 0)
            {
                turnIndicatorBack.SetActive(true);
                yellowTurnIndicator.SetActive(true);
                turnText.GetComponent<TMPro.TextMeshProUGUI>().text = "Yellow's Turn";

                yield return StartCoroutine(YellowTurn());

                yield return Wait(1.25f);

                turnIndicatorBack.SetActive(false);
                yellowTurnIndicator.SetActive(false);
            }

            diceSides[diceNum - 1].SetActive(false);
            yield return Wait(0.75f);


            Debug.Log("Blue turn");
            if (bluePieces > 0)
            {
                turnIndicatorBack.SetActive(true);
                blueTurnIndicator.SetActive(true);
                turnText.GetComponent<TMPro.TextMeshProUGUI>().text = "Blue's Turn";

                yield return StartCoroutine(BlueTurn());

                yield return Wait(1.25f);

                turnIndicatorBack.SetActive(false);
                blueTurnIndicator.SetActive(false);
            }

            diceSides[diceNum - 1].SetActive(false);
            yield return Wait(0.75f);


            yield return null;

        }
    }


    /////////////////////////////////
    //PLAYER FUNCTIONS AND COROUTINES  
    /////////////////////////////////
    public IEnumerator PlayerTurn()
    {
        yield return StartCoroutine(WaitForDiceRoll());
        Debug.Log("Waiting for dice roll complete");

        //PROJECT POTENTIAL MOVES
        if (redPiece1Exists == true)
        {
            ProjectPlayerMoves(ref redPiece1Location, redPiece1, ref redPiece1InHolder, ref redPiece1Moveable, ref redPiece1NewLocation, ref redPiece1ProjectionParent, ref redPiece1Projection, ref redPiece1KnockOff);
        }
        if (redPiece2Exists == true)
        {
            ProjectPlayerMoves(ref redPiece2Location, redPiece2, ref redPiece2InHolder, ref redPiece2Moveable, ref redPiece2NewLocation, ref redPiece2ProjectionParent, ref redPiece2Projection, ref redPiece2KnockOff);
        }
        if (redPiece3Exists == true)
        {
            ProjectPlayerMoves(ref redPiece3Location, redPiece3, ref redPiece3InHolder, ref redPiece3Moveable, ref redPiece3NewLocation, ref redPiece3ProjectionParent, ref redPiece3Projection, ref redPiece3KnockOff);
        }
        if (redPiece4Exists == true)
        {
            ProjectPlayerMoves(ref redPiece4Location, redPiece4, ref redPiece4InHolder, ref redPiece4Moveable, ref redPiece4NewLocation, ref redPiece4ProjectionParent, ref redPiece4Projection, ref redPiece4KnockOff);
        }

        //MOVE PIECE START
        if ((redPiece1Exists == true && redPiece1Moveable == true) | (redPiece2Exists == true && redPiece2Moveable == true) | (redPiece3Exists == true && redPiece3Moveable == true) | (redPiece4Exists == true && redPiece4Moveable == true))
        {
            yield return StartCoroutine(WaitForPlayerMove());
        }
        
        //GIVES THE PLAYER ANOTHER TURN IF NEEDED
        if (diceNum == 6)
        {
            yield return Wait(1);
            diceSides[diceNum - 1].SetActive(false);
            yield return StartCoroutine(Wait(0.1f));
            yield return StartCoroutine(PlayerTurn());
        }
    }

    public void ProjectPlayerMoves(ref int pieceLocation, GameObject piece, ref bool pieceInHolder, ref bool pieceMoveable, ref int pieceNewLocation, ref GameObject pieceProjectionParent, ref GameObject pieceProjection, ref bool pieceKnockOff)
    {
        pieceLocation = piece.transform.parent.gameObject.GetComponent<Board>().redValue;
        Debug.Log(pieceLocation + " is the location of the piece");

        pieceNewLocation = 0;

        //CHECK IF IN HOLDER
        if (pieceLocation == -5)
        {
            pieceInHolder = true;
            Debug.Log(piece + " is in holder");
        }
        else
        {
            pieceInHolder = false;
            Debug.Log(piece + " is not in holder");
            pieceMoveable = true;
        }

        //CHECK IF MOVEABLE AND FIND NEW LOCATION
        if ((pieceInHolder == true && diceNum != 6) | (pieceLocation + diceNum > 26))
        {
            pieceMoveable = false;
        }
        else if (pieceInHolder == true && diceNum == 6)
        {
            pieceMoveable = true;
            pieceNewLocation = 1;
            Debug.Log(pieceNewLocation + " is the new location");
        }
        else if (pieceInHolder == false)
        {
            pieceLocation = piece.transform.parent.gameObject.GetComponent<Board>().redValue;
            pieceNewLocation = pieceLocation + diceNum;
            Debug.Log(pieceNewLocation + " = " + pieceLocation + " + "+ diceNum);
            pieceMoveable = true;
        }

        //FIND AND PROJECT NEW BOARD LOCATION
        if (pieceMoveable == true)
        {
            for (int i = 0; i < boardPieces.Length; i++)
            {
                if (pieceNewLocation == boardPieces[i].transform.GetComponent<Board>().redValue)
                {
                    pieceProjectionParent = boardPieces[i];               
                    PlayerBoardChildCheck(pieceProjectionParent, "Red", ref pieceMoveable, ref pieceKnockOff);

                    pieceProjection.transform.position = pieceProjectionParent.transform.position;
                }
            }

            //CHECK FOR BLOCKER
            for (int i = 0; i < boardPieces.Length; i++)
            {
                if ((boardPieces[i].transform.GetComponent<Board>().redValue > pieceLocation) && (boardPieces[i].transform.GetComponent<Board>().redValue < pieceNewLocation + 1))
                {
                    if (boardPieces[i].transform.childCount > 1)
                    {
                        pieceMoveable = false;
                    }
                }
            }

        }
    }


    public void MovePlayerPiece(GameObject piece, GameObject pieceProjectionParent, ref GameObject pieceProjection, ref int pieceLocation, ref bool pieceExist, ref bool pieceKnockOff)
    {
        //MOVES PIECE
        if (pieceKnockOff == true)
        {
            check = pieceProjectionParent.gameObject.transform.GetChild(0).gameObject;
            Debug.Log(check);
            ResetPiece(check);
        }

        piece.transform.parent = pieceProjectionParent.transform;
        piece.transform.position = pieceProjectionParent.transform.position + new Vector3(0, 2, 0);
        Debug.Log("Piece moved");
        pieceProjection.transform.parent = piece.transform;
        pieceProjection.transform.position = piece.transform.position;

        //DESTROYS PIECE IF NEEDED
        pieceLocation = piece.transform.parent.gameObject.GetComponent<Board>().redValue;

        if (pieceLocation == 26)
        {
            Destroy(piece);
            Destroy(pieceProjection);
            pieceExist = false;
            redPieces = redPieces - 1;
        }

        pieceMoved = true;

        //DISABLES PROJECTION FOR ALL EXISTING PIECES
        if (redPiece1Exists == true)
        {
            redPiece1Projection.SetActive(false);
            Debug.Log("Projection 1 disabled");
            redPiece1Projection.transform.parent = redPiece1.transform;
            redPiece1Projection.transform.position = redPiece1.transform.position;
        }
        if (redPiece2Exists == true)
        {
            redPiece2Projection.SetActive(false);
            Debug.Log("Projection 2 disabled");
            redPiece2Projection.transform.parent = redPiece2.transform;
            redPiece2Projection.transform.position = redPiece2.transform.position;
        }
        if (redPiece3Exists == true)
        {
            redPiece3Projection.SetActive(false);
            Debug.Log("Projection 3 disabled");
            redPiece3Projection.transform.parent = redPiece3.transform;
            redPiece3Projection.transform.position = redPiece3.transform.position;
        }
        if (redPiece4Exists == true)
        {
            redPiece4Projection.SetActive(false);
            Debug.Log("Projection 4 disabled");
            redPiece4Projection.transform.parent = redPiece4.transform;
            redPiece4Projection.transform.position = redPiece4.transform.position;
        }
    }

    public IEnumerator WaitForPlayerMove()
    {
        //RESETTING VARIABLES
        moved = false;
        pieceMoved = false;

        //ENABLING SCRIPTS
        if (redPiece1Exists == true && redPiece1Moveable == true)
        {
            redPiece1.transform.GetComponent<RedPiece1>().enabled = true;
        }
        if (redPiece2Exists == true && redPiece2Moveable == true)
        {
            redPiece2.transform.GetComponent<RedPiece2>().enabled = true;
        }
        if (redPiece3Exists == true && redPiece3Moveable == true)
        {
            redPiece3.transform.GetComponent<RedPiece3>().enabled = true;
        }
        if (redPiece4Exists == true && redPiece4Moveable == true)
        {
            redPiece4.transform.GetComponent<RedPiece4>().enabled = true;
        }

        //WAITING FOR MOVE FUNCTION TO COMPLETE
        while (moved == false)
        {
            if (pieceMoved == true)
            {
                moved = true;

                //DISABLING SCRIPTS
                if (redPiece1Exists == true)
                {
                    redPiece1.transform.GetComponent<RedPiece1>().enabled = false;
                }
                if (redPiece2Exists == true)
                {
                    redPiece2.transform.GetComponent<RedPiece2>().enabled = false;
                }
                if (redPiece3Exists == true)
                {
                    redPiece3.transform.GetComponent<RedPiece3>().enabled = false;
                }
                if (redPiece4Exists == true)
                {
                    redPiece4.transform.GetComponent<RedPiece4>().enabled = false;
                }
            }
            yield return null;

        }
    }

    public IEnumerator WaitForDiceRoll()
    {
        newRoll = false;
        Debug.Log("Waiting for dice roll");
        rolled = false;
        rollDiceButton.SetActive(true);
        while (rolled == false)
        {
            if (newRoll == true)
            {
                rolled = true;
            }
            yield return null;

        }
    }

    public void PlayerBoardChildCheck(GameObject pieceProjectionParent, string colour, ref bool pieceMoveable, ref bool pieceKnockOff)
    {
        pieceKnockOff = false;
        if (pieceProjectionParent.transform.childCount == 1)
        {
            check = pieceProjectionParent.gameObject.transform.GetChild(0).gameObject;
            Debug.Log(check);
            if (colour != check.transform.GetComponent<PieceColour>().colour)
            {
                pieceKnockOff = true;
            }

            else if (pieceProjectionParent.transform.childCount > 1)
            {
                pieceMoveable = false;
            }
        }
    }


    ////////////////////////////////
    //GREEN FUNCTIONS AND COROUTINES
    ////////////////////////////////
    public IEnumerator GreenTurn()
    {
        yield return StartCoroutine(RollDice());

        //PROJECT POTENTIAL MOVES
        if (greenPiece1Exists == true)
        {
            greenPiece1Location = greenPiece1.transform.parent.GetComponent<Board>().greenValue;
            Debug.Log("Green piece location is " + greenPiece1Location);

            ProjectMoves(ref greenPiece1Location, ref greenPiece1InHolder, ref greenPiece1Moveable, ref greenPiece1NewLocation, ref greenPiece1Priority);
            if (greenPiece1Moveable == true)
            {
                FinishProjectingGreenMoves(greenPiece1Location, ref greenPiece1NewLocation, ref greenPiece1ProjectionParent, ref greenPiece1Priority, ref greenPiece1Moveable);
            }
        }
        if (greenPiece2Exists == true)
        {
            greenPiece2Location = greenPiece2.transform.parent.GetComponent<Board>().greenValue;
            Debug.Log("Green piece location is " + greenPiece2Location);

            ProjectMoves(ref greenPiece2Location, ref greenPiece2InHolder, ref greenPiece2Moveable, ref greenPiece2NewLocation, ref greenPiece2Priority);
            if (greenPiece2Moveable == true)
            {
                FinishProjectingGreenMoves(greenPiece2Location, ref greenPiece2NewLocation, ref greenPiece2ProjectionParent, ref greenPiece2Priority, ref greenPiece2Moveable);
            }
        }
        if (greenPiece3Exists == true)
        {
            greenPiece3Location = greenPiece3.transform.parent.GetComponent<Board>().greenValue;
            Debug.Log("Green piece location is " + greenPiece3Location);

            ProjectMoves(ref greenPiece3Location, ref greenPiece3InHolder, ref greenPiece3Moveable, ref greenPiece3NewLocation, ref greenPiece3Priority);
            if (greenPiece3Moveable == true)
            {
                FinishProjectingGreenMoves(greenPiece3Location, ref greenPiece3NewLocation, ref greenPiece3ProjectionParent, ref greenPiece3Priority, ref greenPiece3Moveable);
            }
        }
        if (greenPiece4Exists == true)
        {
            greenPiece4Location = greenPiece4.transform.parent.GetComponent<Board>().greenValue;
            Debug.Log("Green piece location is " + greenPiece4Location);

            ProjectMoves(ref greenPiece4Location, ref greenPiece4InHolder, ref greenPiece4Moveable, ref greenPiece4NewLocation, ref greenPiece4Priority);
            if (greenPiece4Moveable == true)
            {
                FinishProjectingGreenMoves(greenPiece4Location, ref greenPiece4NewLocation, ref greenPiece4ProjectionParent, ref greenPiece4Priority, ref greenPiece4Moveable);
            }
        }
        
        //DECIDE WHICH GREEN PIECE TO MOVE AND MOVE IT
        if ((greenPiece1Exists == true && greenPiece1Moveable == true) | (greenPiece2Exists == true && greenPiece2Moveable) | (greenPiece3Exists == true && greenPiece3Moveable) | (greenPiece4Exists == true && greenPiece4Moveable == true))
        {
            yield return StartCoroutine(Wait(0.75f));
            DecideWhichPieceToMove(greenPiece1Priority, greenPiece2Priority, greenPiece3Priority, greenPiece4Priority, greenPiece1Location, greenPiece2Location, greenPiece3Location, greenPiece4Location, ref greenPiece1Chosen, ref greenPiece2Chosen, ref greenPiece3Chosen, ref greenPiece4Chosen);
            if (greenPiece1Chosen == true)
            {
                MovePiece(greenPiece1, greenPiece1ProjectionParent);
                if (greenPiece1.transform.parent.gameObject.GetComponent<Board>().greenValue == 26)
                {
                    DestroyPiece(greenPiece1, ref greenPiece1Location, ref greenPiece1Exists, ref greenPiece1Priority, ref greenPieces);
                }
            }
            else if (greenPiece2Chosen == true)
            {
                MovePiece(greenPiece2, greenPiece2ProjectionParent);
                if (greenPiece2.transform.parent.gameObject.GetComponent<Board>().greenValue == 26)
                {
                    DestroyPiece(greenPiece2, ref greenPiece2Location, ref greenPiece2Exists, ref greenPiece2Priority, ref greenPieces);
                }
            }
            else if (greenPiece3Chosen == true)
            {
                MovePiece(greenPiece3, greenPiece3ProjectionParent);
                if (greenPiece3.transform.parent.gameObject.GetComponent<Board>().greenValue == 26)
                {
                    DestroyPiece(greenPiece3, ref greenPiece3Location, ref greenPiece3Exists, ref greenPiece3Priority, ref greenPieces);
                }
            }
            else if (greenPiece4Chosen == true)
            {
                MovePiece(greenPiece4, greenPiece4ProjectionParent);
                if (greenPiece4.transform.parent.gameObject.GetComponent<Board>().greenValue == 26)
                {
                    DestroyPiece(greenPiece4, ref greenPiece4Location, ref greenPiece4Exists, ref greenPiece4Priority, ref greenPieces);
                }
            }
        }

        //GIVES GREEN ANOTHER TURN IF NEEDED
        if (diceNum == 6)
        {
            yield return Wait(1);
            diceSides[diceNum - 1].SetActive(false);
            yield return StartCoroutine(Wait(0.1f));
            Debug.Log("Roll Again");
            yield return StartCoroutine(GreenTurn());
        }
    }

    public void FinishProjectingGreenMoves(int pieceLocation, ref int pieceNewLocation, ref GameObject pieceProjectionParent, ref int piecePriority, ref bool pieceMoveable)
    {
        //FIND NEW BOARD LOCATION
        for (int i = 0; i < boardPieces.Length; i++)
        {
            if (pieceNewLocation == boardPieces[i].transform.GetComponent<Board>().greenValue)
            {
                pieceProjectionParent = boardPieces[i];
                Debug.Log(piecePriority);
                BoardChildCheck(pieceProjectionParent, "Green", ref piecePriority, ref pieceMoveable);
                Debug.Log(piecePriority);
            }
        }

        //CHECK FOR BLOCKER
        for (int i = 0; i < boardPieces.Length; i++)
        {
            if ((boardPieces[i].transform.GetComponent<Board>().greenValue > pieceLocation) && (boardPieces[i].transform.GetComponent<Board>().greenValue < pieceNewLocation + 1))
            {
                if (boardPieces[i].transform.childCount > 1)
                {
                    piecePriority = 0;
                    pieceMoveable = false;
                }
            }
        }
        Debug.Log(piecePriority);
    }


    /////////////////////////////////
    //YELLOW FUNCTIONS AND COROUTINES
    /////////////////////////////////
    public IEnumerator YellowTurn()
    {
        yield return StartCoroutine(RollDice());

        //PROJECT POTENTIAL MOVES
        if (yellowPiece1Exists == true)
        {
            yellowPiece1Location = yellowPiece1.transform.parent.GetComponent<Board>().yellowValue;
            Debug.Log("yellow piece location is " + yellowPiece1Location);

            ProjectMoves(ref yellowPiece1Location, ref yellowPiece1InHolder, ref yellowPiece1Moveable, ref yellowPiece1NewLocation, ref yellowPiece1Priority);
            if (yellowPiece1Moveable == true)
            {
                FinishProjectingYellowMoves(yellowPiece1Location, ref yellowPiece1NewLocation, ref yellowPiece1ProjectionParent, ref yellowPiece1Priority, ref yellowPiece1Moveable);
            }
        }
        if (yellowPiece2Exists == true)
        {
            yellowPiece2Location = yellowPiece2.transform.parent.GetComponent<Board>().yellowValue;
            Debug.Log("yellow piece location is " + yellowPiece2Location);

            ProjectMoves(ref yellowPiece2Location, ref yellowPiece2InHolder, ref yellowPiece2Moveable, ref yellowPiece2NewLocation, ref yellowPiece2Priority);
            if (yellowPiece2Moveable == true)
            {
                FinishProjectingYellowMoves(yellowPiece2Location, ref yellowPiece2NewLocation, ref yellowPiece2ProjectionParent, ref yellowPiece2Priority, ref yellowPiece2Moveable);
            }
        }
        if (yellowPiece3Exists == true)
        {
            yellowPiece3Location = yellowPiece3.transform.parent.GetComponent<Board>().yellowValue;
            Debug.Log("yellow piece location is " + yellowPiece3Location);

            ProjectMoves(ref yellowPiece3Location, ref yellowPiece3InHolder, ref yellowPiece3Moveable, ref yellowPiece3NewLocation, ref yellowPiece3Priority);
            if (yellowPiece3Moveable == true)
            {
                FinishProjectingYellowMoves(yellowPiece3Location, ref yellowPiece3NewLocation, ref yellowPiece3ProjectionParent, ref yellowPiece3Priority, ref yellowPiece3Moveable);
            }
        }
        if (yellowPiece4Exists == true)
        {
            yellowPiece4Location = yellowPiece4.transform.parent.GetComponent<Board>().yellowValue;
            Debug.Log("yellow piece location is " + yellowPiece4Location);

            ProjectMoves(ref yellowPiece4Location, ref yellowPiece4InHolder, ref yellowPiece4Moveable, ref yellowPiece4NewLocation, ref yellowPiece4Priority);
            if (yellowPiece4Moveable == true)
            {
                FinishProjectingYellowMoves(yellowPiece4Location, ref yellowPiece4NewLocation, ref yellowPiece4ProjectionParent, ref yellowPiece4Priority, ref yellowPiece4Moveable);
            }
        }

        //DECIDE WHICH YELLOW PIECE TO MOVE AND MOVE IT
        if ((yellowPiece1Exists == true && yellowPiece1Moveable == true) | (yellowPiece2Exists == true && yellowPiece2Moveable == true) | (yellowPiece3Exists == true && yellowPiece3Moveable == true) | (yellowPiece4Exists == true && yellowPiece4Moveable))
        {
            yield return StartCoroutine(Wait(0.75f));
            DecideWhichPieceToMove(yellowPiece1Priority, yellowPiece2Priority, yellowPiece3Priority, yellowPiece4Priority, yellowPiece1Location, yellowPiece2Location, yellowPiece3Location, yellowPiece4Location, ref yellowPiece1Chosen, ref yellowPiece2Chosen, ref yellowPiece3Chosen, ref yellowPiece4Chosen);
            if (yellowPiece1Chosen == true)
            {
                MovePiece(yellowPiece1, yellowPiece1ProjectionParent);
                if (yellowPiece1.transform.parent.gameObject.GetComponent<Board>().yellowValue == 26)
                {
                    DestroyPiece(yellowPiece1, ref yellowPiece1Location, ref yellowPiece1Exists, ref yellowPiece1Priority, ref yellowPieces);
                }
            }
            else if (yellowPiece2Chosen == true)
            {
                MovePiece(yellowPiece2, yellowPiece2ProjectionParent);
                if (yellowPiece2.transform.parent.gameObject.GetComponent<Board>().yellowValue == 26)
                {
                    DestroyPiece(yellowPiece2, ref yellowPiece2Location, ref yellowPiece2Exists, ref yellowPiece2Priority, ref yellowPieces);
                }
            }
            else if (yellowPiece3Chosen == true)
            {
                MovePiece(yellowPiece3, yellowPiece3ProjectionParent);
                if (yellowPiece3.transform.parent.gameObject.GetComponent<Board>().yellowValue == 26)
                {
                    DestroyPiece(yellowPiece3, ref yellowPiece3Location, ref yellowPiece3Exists, ref yellowPiece3Priority, ref yellowPieces);
                }
            }
            else if (yellowPiece4Chosen == true)
            {
                MovePiece(yellowPiece4, yellowPiece4ProjectionParent);
                if (yellowPiece4.transform.parent.gameObject.GetComponent<Board>().yellowValue == 26)
                {
                    DestroyPiece(yellowPiece4, ref yellowPiece4Location, ref yellowPiece4Exists, ref yellowPiece4Priority, ref yellowPieces);
                }
            }
        }

        //GIVES YELLOW ANOTHER TURN IF NEEDED
        if (diceNum == 6)
        {
            yield return Wait(1);
            diceSides[diceNum - 1].SetActive(false);
            yield return StartCoroutine(Wait(0.1f));
            Debug.Log("Roll Again");
            yield return StartCoroutine(YellowTurn());
        }
    }

    public void FinishProjectingYellowMoves(int pieceLocation, ref int pieceNewLocation, ref GameObject pieceProjectionParent, ref int piecePriority, ref bool pieceMoveable)
    {
        //FIND NEW BOARD LOCATION
        for (int i = 0; i < boardPieces.Length; i++)
        {
            if (pieceNewLocation == boardPieces[i].transform.GetComponent<Board>().yellowValue)
            {
                pieceProjectionParent = boardPieces[i];
                Debug.Log(piecePriority);
                BoardChildCheck(pieceProjectionParent, "Yellow", ref piecePriority, ref pieceMoveable);
                Debug.Log(piecePriority);
            }
        }

        //CHECK FOR BLOCKER
        for (int i = 0; i < boardPieces.Length; i++)
        {
            if ((boardPieces[i].transform.GetComponent<Board>().yellowValue > pieceLocation) && (boardPieces[i].transform.GetComponent<Board>().yellowValue < pieceNewLocation + 1))
            {
                if (boardPieces[i].transform.childCount > 1)
                {
                    piecePriority = 0;
                    pieceMoveable = false;
                }
            }
        }
        Debug.Log(piecePriority);
    }


    ///////////////////////////////
    //BLUE FUNCTIONS AND COROUTINES
    ///////////////////////////////
    public IEnumerator BlueTurn()
    {
        yield return StartCoroutine(RollDice());

        //PROJECT POTENTIAL MOVES
        if (bluePiece1Exists == true)
        {
            bluePiece1Location = bluePiece1.transform.parent.GetComponent<Board>().blueValue;
            Debug.Log("Blue piece location is " + bluePiece1Location);

            ProjectMoves(ref bluePiece1Location, ref bluePiece1InHolder, ref bluePiece1Moveable, ref bluePiece1NewLocation, ref bluePiece1Priority);
            if (bluePiece1Moveable == true)
            {
                FinishProjectingBlueMoves(bluePiece1Location, ref bluePiece1NewLocation, ref bluePiece1ProjectionParent, ref bluePiece1Priority, ref bluePiece1Moveable);
            }
        }
        if (bluePiece2Exists == true)
        {
            bluePiece2Location = bluePiece2.transform.parent.GetComponent<Board>().blueValue;
            Debug.Log("Blue piece location is " + bluePiece2Location);

            ProjectMoves(ref bluePiece2Location, ref bluePiece2InHolder, ref bluePiece2Moveable, ref bluePiece2NewLocation, ref bluePiece2Priority);
            if (bluePiece2Moveable == true)
            {
                FinishProjectingBlueMoves(bluePiece2Location, ref bluePiece2NewLocation, ref bluePiece2ProjectionParent, ref bluePiece2Priority, ref bluePiece2Moveable);
            }
        }
        if (bluePiece3Exists == true)
        {
            bluePiece3Location = bluePiece3.transform.parent.GetComponent<Board>().blueValue;
            Debug.Log("Blue piece location is " + bluePiece3Location);

            ProjectMoves(ref bluePiece3Location, ref bluePiece3InHolder, ref bluePiece3Moveable, ref bluePiece3NewLocation, ref bluePiece3Priority);
            if (bluePiece3Moveable == true)
            {
                FinishProjectingBlueMoves(bluePiece3Location, ref bluePiece3NewLocation, ref bluePiece3ProjectionParent, ref bluePiece3Priority, ref bluePiece3Moveable);
            }
        }
        if (bluePiece4Exists == true)
        {
            bluePiece4Location = bluePiece4.transform.parent.GetComponent<Board>().blueValue;
            Debug.Log("Blue piece location is " + bluePiece4Location);

            ProjectMoves(ref bluePiece4Location, ref bluePiece4InHolder, ref bluePiece4Moveable, ref bluePiece4NewLocation, ref bluePiece4Priority);
            if (bluePiece4Moveable == true)
            {
                FinishProjectingBlueMoves(bluePiece4Location, ref bluePiece4NewLocation, ref bluePiece4ProjectionParent, ref bluePiece4Priority, ref bluePiece4Moveable);
            }
        }

        //DECIDE WHICH BLUE PIECE TO MOVE AND MOVE IT
        if ((bluePiece1Exists == true && bluePiece1Moveable == true) | (bluePiece2Exists == true && bluePiece2Moveable) | (bluePiece3Exists == true && bluePiece3Moveable == true) | (bluePiece4Exists == true && bluePiece4Moveable))
        {
            yield return StartCoroutine(Wait(0.75f));
            DecideWhichPieceToMove(bluePiece1Priority, bluePiece2Priority, bluePiece3Priority, bluePiece4Priority, bluePiece1Location, bluePiece2Location, bluePiece3Location, bluePiece4Location, ref bluePiece1Chosen, ref bluePiece2Chosen, ref bluePiece3Chosen, ref bluePiece4Chosen);
            if (bluePiece1Chosen == true)
            {
                MovePiece(bluePiece1, bluePiece1ProjectionParent);
                if (bluePiece1.transform.parent.gameObject.GetComponent<Board>().blueValue == 26)
                {
                    DestroyPiece(bluePiece1, ref bluePiece1Location, ref bluePiece1Exists, ref bluePiece1Priority, ref bluePieces);
                }
            }
            else if (bluePiece2Chosen == true)
            {
                MovePiece(bluePiece2, bluePiece2ProjectionParent);
                if (bluePiece2.transform.parent.gameObject.GetComponent<Board>().blueValue == 26)
                {
                    DestroyPiece(bluePiece2, ref bluePiece2Location, ref bluePiece2Exists, ref bluePiece2Priority, ref bluePieces);
                }
            }
            else if (bluePiece3Chosen == true)
            {
                MovePiece(bluePiece3, bluePiece3ProjectionParent);
                if (bluePiece3.transform.parent.gameObject.GetComponent<Board>().blueValue == 26)
                {
                    DestroyPiece(bluePiece3, ref bluePiece3Location, ref bluePiece3Exists, ref bluePiece3Priority, ref bluePieces);
                }
            }
            else if (bluePiece4Chosen == true)
            {
                MovePiece(bluePiece4, bluePiece4ProjectionParent);
                if (bluePiece4.transform.parent.gameObject.GetComponent<Board>().blueValue == 26)
                {
                    DestroyPiece(bluePiece4, ref bluePiece1Location, ref bluePiece4Exists, ref bluePiece4Priority, ref bluePieces);
                }
            }
        }

        //GIVES BLUE ANOTHER TURN IF NEEDED
        if (diceNum == 6)
        {
            yield return Wait(1);
            diceSides[diceNum - 1].SetActive(false);
            yield return StartCoroutine(Wait(0.1f));
            Debug.Log("Roll Again");
            yield return StartCoroutine(BlueTurn());
        }

    }

    public void FinishProjectingBlueMoves(int pieceLocation, ref int pieceNewLocation, ref GameObject pieceProjectionParent, ref int piecePriority, ref bool pieceMoveable)
    {
        //FIND NEW BOARD LOCATION
        for (int i = 0; i < boardPieces.Length; i++)
        {
            if (pieceNewLocation == boardPieces[i].transform.GetComponent<Board>().blueValue)
            {
                pieceProjectionParent = boardPieces[i];
                Debug.Log(piecePriority);
                BoardChildCheck(pieceProjectionParent, "Blue", ref piecePriority, ref pieceMoveable);
                Debug.Log(piecePriority);
            }
        }

        //CHECK FOR BLOCKER
        for (int i = 0; i < boardPieces.Length; i++)
        {
            if ((boardPieces[i].transform.GetComponent<Board>().blueValue > pieceLocation) && (boardPieces[i].transform.GetComponent<Board>().blueValue < pieceNewLocation + 1))
            {
                if (boardPieces[i].transform.childCount > 1)
                {
                    piecePriority = 0;
                    pieceMoveable = false;
                }
            }
        }
        Debug.Log(piecePriority);
    }


    //////////////////////////////////////////
    //FUNCTIONS AND COROUTINES FOR ALL PLAYERS
    //////////////////////////////////////////
    public IEnumerator RollDice()
    {
        diceNum = 1;
        rollDiceButton.SetActive(false);

        for (int i = 0; i < 15; i++)
        {
            diceSides[diceNum - 1].SetActive(false);
            diceNum = Random.Range(1, 7);
            diceSides[diceNum - 1].SetActive(true);
            yield return StartCoroutine(Wait(0.05f));
        }

        diceSides[diceNum - 1].SetActive(false);
        diceNum = Random.Range(1, 7);
        Debug.Log(diceNum + " was rolled");
        diceSides[diceNum - 1].SetActive(true);
        newRoll = true;
    }

    public void ButtonPress()
    {
        StartCoroutine(RollDice());
    }

    public IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

    public void ProjectMoves(ref int pieceLocation, ref bool pieceInHolder, ref bool pieceMoveable, ref int pieceNewLocation, ref int piecePriority)
    {
        //CHECK IF IN HOLDER
        if (pieceLocation == -5)
        {
            pieceInHolder = true;
        }
        else
        {
            pieceInHolder = false;
            pieceMoveable = true;
        }

        //CHECK IF MOVEABLE AND FIND NEW LOCATION
        if ((pieceInHolder == true && diceNum != 6) | (pieceLocation + diceNum > 26))
        {
            pieceMoveable = false;
            piecePriority = 0;
        }
        else if (pieceInHolder == true && diceNum == 6)
        {
            pieceMoveable = true;
            pieceNewLocation = 1;
            Debug.Log(pieceNewLocation + " is the new location");
            piecePriority = Random.Range(1,3); ///////////////////////
        }
        else if (pieceInHolder == false)
        {
            pieceNewLocation = pieceLocation + diceNum;
            pieceMoveable = true;

            if (pieceNewLocation == 26)
            {
                piecePriority = 6;
            }
            else if (pieceNewLocation > 23 && pieceNewLocation < 26)
            {
                piecePriority = 4;
            }
            else
            {
                piecePriority = 1;
            }
        }
    }

    public void BoardChildCheck(GameObject pieceProjectionParent, string colour, ref int piecePriority, ref bool pieceMoveable)
    {
        if (pieceProjectionParent.transform.childCount == 1)
        {
            check = pieceProjectionParent.gameObject.transform.GetChild(0).gameObject;
            Debug.Log(check);

            if (colour != check.transform.GetComponent<PieceColour>().colour)
            {
                piecePriority = 5;
                Debug.Log(piecePriority);
                ResetPiece(check);
            }
            else if (colour == check.transform.GetComponent<PieceColour>().colour)
            {
                piecePriority = 3;
            }
        }
        else if (pieceProjectionParent.transform.childCount > 1)
        {
            pieceMoveable = false;
            piecePriority = 0;
        }
    }

    public void ResetPiece(GameObject check)
    {
        if (check.transform.GetComponent<PieceColour>().colour == "Red")
        {
            check.transform.parent = redHolder.transform;
            if (check == redPiece1)
            {
                check.transform.position = redHolder.transform.position + new Vector3(-5, 2, -5);
            }
            else if (check == redPiece2)
            {
                check.transform.position = redHolder.transform.position + new Vector3(-5, 2, 5);
            }
            else if (check == redPiece3)
            {
                check.transform.position = redHolder.transform.position + new Vector3(5, 2, -5);
            }
            else if (check == redPiece4)
            {
                check.transform.position = redHolder.transform.position + new Vector3(5, 2, 5);
            }
            Debug.Log("Red Piece Reset");
        }
        else if (check.transform.GetComponent<PieceColour>().colour == "Green")
        {
            check.transform.parent = greenHolder.transform;
            if (check == greenPiece1)
            {
                check.transform.position = greenHolder.transform.position + new Vector3(-5, 2, 5);
            }
            else if (check == greenPiece2)
            {
                check.transform.position = greenHolder.transform.position + new Vector3(-5, 2, -5);
            }
            else if (check == greenPiece3)
            {
                check.transform.position = greenHolder.transform.position + new Vector3(5, 2, 5);
            }
            else if (check == greenPiece4)
            {
                check.transform.position = greenHolder.transform.position + new Vector3(5, 2, -5);
            }
            Debug.Log("Green Piece Reset");
        }
        else if (check.transform.GetComponent<PieceColour>().colour == "Yellow")
        {
            check.transform.parent = yellowHolder.transform;
            if (check == yellowPiece1)
            {
                check.transform.position = yellowHolder.transform.position + new Vector3(5, 2, 5);
            }
            else if (check == yellowPiece2)
            {
                check.transform.position = yellowHolder.transform.position + new Vector3(5, 2, -5);
            }
            else if (check == yellowPiece3)
            {
                check.transform.position = yellowHolder.transform.position + new Vector3(-5, 2, 5);
            }
            else if (check == yellowPiece4)
            {
                check.transform.position = yellowHolder.transform.position + new Vector3(-5, 2, -5);
            }
            Debug.Log("Yellow Piece Reset");
        }
        else if (check.transform.GetComponent<PieceColour>().colour == "Blue")
        {
            check.transform.parent = blueHolder.transform;
            if (check == bluePiece1)
            {
                check.transform.position = blueHolder.transform.position + new Vector3(5, 2, -5);
            }
            else if (check == bluePiece2)
            {
                check.transform.position = blueHolder.transform.position + new Vector3(5, 2, 5);
            }
            else if (check == bluePiece3)
            {
                check.transform.position = blueHolder.transform.position + new Vector3(-5, 2, -5);
            }
            else if (check == bluePiece4)
            {
                check.transform.position = blueHolder.transform.position + new Vector3(-5, 2, 5);
            }
            Debug.Log("Piece Reset");
        }
    }

    public void DecideWhichPieceToMove(int piece1Priority, int piece2Priority, int piece3Priority, int piece4Priority, int piece1Location, int piece2Location, int piece3Location, int piece4Location, ref bool piece1Chosen, ref bool piece2Chosen, ref bool piece3Chosen, ref bool piece4Chosen)
    {
        Debug.Log("Piece 1 priority = " + piece1Priority);
        Debug.Log("Piece 2 priority = " + piece2Priority);
        Debug.Log("Piece 3 priority = " + piece3Priority);
        Debug.Log("Piece 4 priority = " + piece4Priority);

        piece1Chosen = false;
        piece2Chosen = false;
        piece3Chosen = false;
        piece4Chosen = false;

        if (piece1Priority == piece2Priority && piece2Priority == piece3Priority && piece3Priority == piece4Priority)
        {
            if ((piece1Location >= piece2Location) && (piece1Location >= piece3Location) && (piece1Location >= piece4Location))
            {
                piece1Chosen = true;
            }
            else if ((piece2Location >= piece1Location) && (piece2Location >= piece3Location) && (piece2Location >= piece4Location))
            {
                piece2Chosen = true;
            }
            else if ((piece3Location >= piece1Location) && (piece3Location >= piece2Location) && (piece3Location >= piece4Location))
            {
                piece3Chosen = true;
            }
            else if ((piece4Location >= piece1Location) && (piece4Location >= piece2Location) && (piece4Location >= piece3Location))
            {
                piece4Chosen = true;
            }
        }
        else if ((piece1Priority >= piece2Priority) && (piece1Priority >= piece3Priority) && (piece1Priority >= piece4Priority))
        {
            piece1Chosen = true;
        }
        else if ((piece2Priority >= piece1Priority) && (piece2Priority >= piece3Priority) && (piece2Priority >= piece4Priority))
        {
            piece2Chosen = true;
        }
        else if ((piece3Priority >= piece1Priority) && (piece3Priority >= piece2Priority) && (piece3Priority >= piece4Priority))
        {
            piece3Chosen = true;
        }
        else if ((piece4Priority >= piece1Priority) && (piece4Priority >= piece2Priority) && (piece4Priority >= piece3Priority))
        {
            piece4Chosen = true;
        }
    }

    public void MovePiece(GameObject piece, GameObject pieceProjectionParent)
    {
        piece.transform.parent = pieceProjectionParent.transform;
        piece.transform.position = pieceProjectionParent.transform.position + new Vector3(0, 2, 0);
        Debug.Log("Piece Moved");
    }

    public void DestroyPiece(GameObject piece, ref int pieceLocation, ref bool pieceExist, ref int piecePriority, ref int pieces)
    {
        Destroy(piece);
        pieceExist = false;
        piecePriority = 0;
        pieceLocation = 0;
        pieces = pieces - 1;
        if (pieces == 0)
        {
            players = players - 1;
            placement = placement + 1;
        }
    }

    public void blockCheck()
    {
        for (int z = 0; z < neutralBoard.Length; z++)
        {
            if (neutralBoard[z].transform.childCount > 1)
            {
                neutralBoard[z].GetComponent<MeshRenderer>().material = neutralBlockMaterial;
            }
            else
            {
                neutralBoard[z].GetComponent<MeshRenderer>().material = neutralBoardMaterial;
            }
        }

        for (int z = 0; z < redBoard.Length; z++)
        {
            if (redBoard[z].transform.childCount > 1)
            {
                redBoard[z].GetComponent<MeshRenderer>().material = redBlockMaterial;
            }
            else
            {
                redBoard[z].GetComponent<MeshRenderer>().material = redBoardMaterial;
            }
        }

        for (int z = 0; z < greenBoard.Length; z++)
        {
            if (greenBoard[z].transform.childCount > 1)
            {
                greenBoard[z].GetComponent<MeshRenderer>().material = greenBlockMaterial;
            }
            else
            {
                greenBoard[z].GetComponent<MeshRenderer>().material = greenBoardMaterial;
            }
        }

        for (int z = 0; z < yellowBoard.Length; z++)
        {
            if (yellowBoard[z].transform.childCount > 1)
            {
                yellowBoard[z].GetComponent<MeshRenderer>().material = yellowBlockMaterial;
            }
            else
            {
                yellowBoard[z].GetComponent<MeshRenderer>().material = yellowBoardMaterial;
            }
        }

        for (int z = 0; z < blueBoard.Length; z++)
        {
            if (blueBoard[z].transform.childCount > 1)
            {
                blueBoard[z].GetComponent<MeshRenderer>().material = blueBlockMaterial;
            }
            else
            {
                blueBoard[z].GetComponent<MeshRenderer>().material = blueBoardMaterial;
            }
        }

        if (redArrowBoard.transform.childCount > 1)
        {
            redArrowBoard.GetComponent<MeshRenderer>().material = neutralBlockMaterial;
        }
        else
        {
            redArrowBoard.GetComponent<MeshRenderer>().material = redArrowMaterial;
        }

        if (greenArrowBoard.transform.childCount > 1)
        {
            greenArrowBoard.GetComponent<MeshRenderer>().material = neutralBlockMaterial;
        }
        else
        {
            greenArrowBoard.GetComponent<MeshRenderer>().material = greenArrowMaterial;
        }

        if (yellowArrowBoard.transform.childCount > 1)
        {
            yellowArrowBoard.GetComponent<MeshRenderer>().material = neutralBlockMaterial;
        }
        else
        {
            yellowArrowBoard.GetComponent<MeshRenderer>().material = yellowArrowMaterial;
        }

        if (blueArrowBoard.transform.childCount > 1)
        {
            blueArrowBoard.GetComponent<MeshRenderer>().material = neutralBlockMaterial;
        }
        else
        {
            blueArrowBoard.GetComponent<MeshRenderer>().material = blueArrowMaterial;
        }
    }
}
