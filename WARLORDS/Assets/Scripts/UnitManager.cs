using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public static UnitManager unitManager;
    public bool unitMoving = false;
    public PlayerMove[] units;

    void Awake()
    {
        unitManager = this;
    }

    public void FindAllUnits()
    {
        units = GameObject.FindObjectsOfType<PlayerMove>();
    }

    public void DisableUnitMovement()
    {
        //foreach(PlayerMove pieces in units)
        //{
        //    pieces.canMove = false;
        //}
    }
    public void EnableUnitMovement()
    {

        //foreach (PlayerMove pieces in units)
        //{
        //    pieces.canMove = true;
        //}
    }
}
