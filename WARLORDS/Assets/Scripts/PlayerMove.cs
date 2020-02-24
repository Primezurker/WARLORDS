using UnityEngine;

public class PlayerMove : TacticsMove 
{
    int attackRange = 0;
    Renderer rend;

	void Start () 
	{
        Init();
        move = stats.actionPoints;
        attackRange = stats.attackRange;
        rend = GetComponent<Renderer>();
    }

	void Update ()
	{
        Debug.DrawRay(transform.position, transform.forward);
        if (canMove == true)
        {
            if (!active)
            {
                return;
            }

            if (!moving)
            {
                FindSelectableTiles();
                CheckMouse();
                UnitManager.unitManager.unitMoving = false;
                TurnSystem.turnSystem.beginCountDown = true;
            }
            else
            {
                TurnSystem.turnSystem.beginCountDown = false;
                UnitManager.unitManager.unitMoving = true;
                Move();
            }
        }
        else
        {
            return;
        }
	}

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();

                    if (t.selectable)
                    {
                        MoveToTile(t);
                    }
                }
            }
        }
    }

    void OnMouseOver()
    {
        if(UnitManager.unitManager.unitMoving == false)
        {
            if (selected == false)
            {
                rend.material.color = Color.yellow;
            }
            else
            {
                rend.material.color = Color.green;
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                PlayerMove[] playerMove = FindObjectsOfType<PlayerMove>();
                foreach (PlayerMove pm in playerMove)
                {
                    pm.selected = false;
                    pm.active = false;
                    pm.GetComponent<Renderer>().material.color = Color.blue;
                }
                selected = true;
                active = true;

            }
        }
    }
    void OnMouseExit()
    {
        if(selected == false)
        {
            rend.material.color = Color.blue;
        }
        else
        {
            rend.material.color = Color.green;
        }
    }

    void FindEnemiesInRange()
    {

    }
}
