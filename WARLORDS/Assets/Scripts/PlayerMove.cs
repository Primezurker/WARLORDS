using UnityEngine;

public class PlayerMove : TacticsMove 
{
    public bool active;

	void Start () 
	{
        Init();
        move = stats.actionPoints;
	}

	void Update () 
	{
        Debug.DrawRay(transform.position, transform.forward);

        if (!active)
        {
            return;
        }

        if (!moving)
        {
            FindSelectableTiles();
            CheckMouse();
        }
        else
        {
            Move();
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
        active = true;
    }
}
