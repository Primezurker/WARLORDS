using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour 
{
    public bool walkable = true;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;

    public List<Tile> adjacencyList = new List<Tile>();

    public bool visited = false;
    public Tile parent = null;
    public int distance = 0;

    public float f = 0;
    public float g = 0;
    public float h = 0;

    [Header("Tile Colors")]
    [SerializeField] Color standingOnColor = Color.white;
    [SerializeField] Color targetColor = Color.yellow;
    [SerializeField] Color selectableColor = Color.blue;
    public Color baseColor;

    Color playerTileColor;
    Color enemyTileColor;
    Color battlefieldTileColor;

    void Awake()
    {
        playerTileColor = Resources.Load<Material>("PlayerTileMat").color;
        enemyTileColor = Resources.Load<Material>("EnemyTileMat").color;
        battlefieldTileColor = Resources.Load<Material>("BattlefieldTileMat").color;

        standingOnColor = Color.white;
        targetColor = Color.yellow;
        selectableColor = Color.blue;
    }

    void Update()
    {
        if (current)
        {
            GetComponent<Renderer>().material.color = standingOnColor;
        }
        else if (target)
        {
            GetComponent<Renderer>().material.color = targetColor;
        }
        else if (selectable)
        {
            GetComponent<Renderer>().material.color = selectableColor;
        }
        else
        {
            if(gameObject.layer == 8)
            {
                baseColor = playerTileColor;
                GetComponent<Renderer>().material.color = baseColor;

            }
            else if (gameObject.layer == 9)
            {
                baseColor = enemyTileColor;
                GetComponent<Renderer>().material.color = baseColor;
            }
            else if(gameObject.layer == 10)
            {
                baseColor = battlefieldTileColor;
                GetComponent<Renderer>().material.color = baseColor;
            }
        }
    }

    public void Reset()
    {
        adjacencyList.Clear();

        current = false;
        target = false;
        selectable = false;

        visited = false;
        parent = null;
        distance = 0;

        f = g = h = 0;
    }

    public void FindNeighbors(float jumpHeight, Tile target)
    {
        Reset();

        CheckTile(Vector3.forward, jumpHeight, target);
        CheckTile(-Vector3.forward, jumpHeight, target);
        CheckTile(Vector3.right, jumpHeight, target);
        CheckTile(-Vector3.right, jumpHeight, target);
    }

    public void CheckTile(Vector3 direction, float jumpHeight, Tile target)
    {
        Vector3 halfExtents = new Vector3(0.25f, (1 + jumpHeight) / 2.0f, 0.25f);
        Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtents);

        foreach (Collider item in colliders)
        {
            Tile tile = item.GetComponent<Tile>();
            if (tile != null && tile.walkable)
            {
                RaycastHit hit;

                if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1) || (tile == target))
                {
                    adjacencyList.Add(tile);
                }
            }
        }
    }
}
