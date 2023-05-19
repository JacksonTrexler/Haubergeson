using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrigTile
{
    public string tileName;
    public int tileID;

    public BrigTile (string name, int ID)
    {
        this.tileName = name;
        this.tileID = ID;
        
    }
}

public class BrigTileFull : BrigTile
{
    public Dictionary<string, int> tileStats = new Dictionary<string, int>();
    public Dictionary<string, int> enterEffects = new Dictionary<string, int>();
    public Dictionary<string, int> exitEffects = new Dictionary<string, int>();
    public Dictionary<string, int> endTurnEffects = new Dictionary<string, int>();
    public Dictionary<string, int> passEffects = new Dictionary<string, int>();

    public int tileCharges;
    //ADDME transformation candidates?
    //When out of charges, transform powered star tile to tapped star tile


    //Optional
    //Enter for effects triggering first time
    //Hiding Place: Hidden
    //ExitEffects for effects triggering as soon as unit leaves tile
    //Leaf Shower: hidden for first space moved
    //EndTurnEffects for effects triggering when unit ends turn on tile
    //Heal Tile: Instantly heal 10% health
    //Pass effects: effects that trigger when a unit passes over
    //Caltrops: Take 3 piercing, lose movement tiles equal to damage dealt.

    public BrigTileFull(string name, int ID, Dictionary<string, int> stats, Dictionary<string, int> enterEffects, Dictionary<string, int> exitEffects, Dictionary<string, int> endTurnEffects, Dictionary<string, int> passEffects, int charges) : base(name, ID)
    {
        this.tileStats = stats;
        this.enterEffects = enterEffects;
        this.exitEffects = exitEffects;
        this.endTurnEffects = endTurnEffects;
        this.passEffects = passEffects;
        this.tileCharges = charges;

    }
}