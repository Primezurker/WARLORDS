using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MenuScript 
{
    //Layer 8 is PlayerTiles
    //Layer 9 is EnemyTiles
    //Layer10 is BattlefieldTiles

    [MenuItem("Tools/Assign Tile Material")]
    public static void AssignTileMaterial()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject t in tiles)
        {
            if(t.gameObject.layer == 8)
            {
                Material playerTileMat = Resources.Load<Material>("PlayerTileMat");
                t.GetComponent<Renderer>().material = playerTileMat;
                t.GetComponent<Tile>().baseColor = playerTileMat.color;
            }
            if(t.gameObject.layer == 9)
            {
                Material enemyTileMat = Resources.Load<Material>("EnemyTileMat");
                t.GetComponent<Renderer>().material = enemyTileMat;
                t.GetComponent<Tile>().baseColor = enemyTileMat.color;
            }
            if (t.gameObject.layer == 10)
            {
                Material battlefieldMat = Resources.Load<Material>("BattlefieldTileMat");
                t.GetComponent<Renderer>().material = battlefieldMat;
                t.GetComponent<Tile>().baseColor = battlefieldMat.color;
            }
        }
    }

    [MenuItem("Tools/Assign Tile Tags")]
    public static void AssignTileTags()
    {
        GameObject[] playerTiles = GameObject.FindGameObjectsWithTag("PlayerTile");
        GameObject[] enemyTiles = GameObject.FindGameObjectsWithTag("EnemyTile");

        foreach(GameObject pT in playerTiles)
        {
            pT.gameObject.tag = "Tile";
        }
        foreach(GameObject eT in enemyTiles)
        {
            eT.gameObject.tag = "Tile";
        }
    }

    [MenuItem("Tools/Assign Tile Script")]
    public static void AssignTileScript()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("Tile");

        foreach (GameObject t in tiles)
        {
            t.AddComponent<Tile>();
        }
    }
}
