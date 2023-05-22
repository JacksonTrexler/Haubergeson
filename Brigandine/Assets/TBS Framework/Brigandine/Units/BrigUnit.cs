using TbsFramework.Units;
using UnityEngine;

public class BrigUnit : Unit
{
    public Color LeadingColor;
    public override void Initialize()
    {
        base.Initialize();
        transform.localPosition -= new Vector3(0, 0, 1);
        GetComponent<Renderer>().material.color = LeadingColor;
    }

    public override void MarkAsFriendly()
    {
        GetComponent<Renderer>().material.color = LeadingColor + new Color(0.8f, 1, 0.8f);
    }

    public override void MarkAsReachableEnemy()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.red;
    }

    public override void MarkAsSelected()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.green;
    }

    public override void UnMark()
    {
        GetComponent<Renderer>().material.color = LeadingColor;
    }

    public override void MarkAsAttacking(Unit other)
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.magenta;
    }

    public override void MarkAsDefending(Unit other)
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.blue;
    }

    public override void MarkAsDestroyed()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.white;
    }

    public override void MarkAsFinished()
    {
        GetComponent<Renderer>().material.color = LeadingColor + Color.gray;
    }
}
