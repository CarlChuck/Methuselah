using NUnit.Framework;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string characterName;
    private Clan clan;
    private Rank rank;
    private int favour;
    private int bloodPool;
    private int bloodCap;
    private int finances;

    #region Disciplines
    private int animalism;
    private int auspex;
    private int celerity;
    private int dominate;
    private int fortitude;
    private int obfuscate;
    private int oblivion;
    private int potence;
    private int presence;
    private int protean;
    private int bloodSorcery;
    #endregion

    public void Start()
    {
        //TEMP until charGen/Save system
        StartingAttributes();
        ZeroDiscs();
        clan = Clan.Unset;
        characterName = "";
        rank = Rank.Ancilae;
    }

    public void StartingAttributes()
    {
        favour = 0;
        bloodPool = 8;
        bloodCap = 20;
        finances = 10;
    }
    public void SetName(string nameToSet)
    {
        characterName = nameToSet;
    }
    public void SetClan(Clan startingClan)
    {
        ZeroDiscs();
        clan = startingClan;

        switch (startingClan)
        {
            case Clan.BanuHaqim:
                celerity = 1;
                obfuscate = 1;
                bloodSorcery = 1;
                break;
            case Clan.Brujah:
                celerity = 1;
                potence = 1;
                presence = 1;
                break;
            case Clan.Gangrel:
                animalism = 1;
                fortitude = 1;
                protean = 1;
                break;
            case Clan.Hecata:
                auspex = 1;
                fortitude = 1;
                oblivion = 1;
                break;
            case Clan.Lasombra:
                dominate = 1;
                potence = 1;
                oblivion = 1;
                break;
            case Clan.Malkavian:
                auspex = 1;
                dominate = 1;
                obfuscate = 1;
                break;
            case Clan.Ministry:
                obfuscate = 1;
                presence = 1;
                protean = 1;
                break;
            case Clan.Nosferatu:
                animalism = 1;
                obfuscate = 1;
                potence = 1;
                break;
            case Clan.Ravnos:
                animalism = 1;
                obfuscate = 1;
                presence = 1;
                break;
            case Clan.Toreador:
                auspex = 1;
                celerity = 1;
                presence = 1;
                break;
            case Clan.Tremere:
                auspex = 1;
                dominate = 1;
                bloodSorcery = 1;
                break;
            case Clan.Tzimisce:
                animalism = 1;
                dominate = 1;
                protean = 1;
                break;
            case Clan.Ventrue:
                fortitude = 1;
                dominate = 1;
                presence = 1;
                break;
        }
    }
    public void ZeroDiscs()
    {
        animalism = 0;
        auspex = 0;
        celerity = 0;
        dominate = 0;
        fortitude = 0;
        obfuscate = 0;
        oblivion = 0;
        potence = 0;
        presence = 0;
        protean = 0;
        bloodSorcery = 0;
    }
    #region AddAttribute
    public void AddFavour(int favourToAdd)
    {
        favour += favourToAdd;
    }
    public void AddBloodPool(int bloodPoolToAdd)
    { 
        bloodPool += bloodPoolToAdd;
        if (bloodPool > bloodCap)
        {
            bloodPool = bloodCap;
        }
    }
    public void AddFinances(int financesToAdd)
    {
        finances += financesToAdd;
    }
    #endregion
    #region Getters
    public Clan GetClan()
    {
        return clan;
    }
    public string GetName()
    {
        return characterName;
    }
    public string GetRankAsString()
    {
        if (rank == Rank.KeeperOfElysium)
        {
            return "Keeper Of Elysium";
        }
        else
        {
            return rank.ToString();
        }
    }
    public int GetFavour()
    {
        return favour; 
    }
    public int GetBloodPool()
    {
        return bloodPool;
    }
    public int GetBloodCap()
    {
        return bloodCap;
    }
    public int GetFinances()
    {
        return finances;
    }
    public int GetAnimalism()
    {
        return animalism;
    }
    public int GetAuspex()
    {
        return auspex;
    }
    public int GetCelerity()
    {
        return celerity;
    }
    public int GetDominate()
    {
        return dominate;
    }
    public int GetFortitude()
    {
        return fortitude;
    }
    public int GetObfuscate()
    {
        return obfuscate;
    }
    public int GetOblivion()
    {
        return oblivion;
    }
    public int GetPotence()
    {
        return potence;
    }
    public int GetPresence()
    {
        return presence;
    }
    public int GetProtean()
    {
        return protean;
    }
    public int GetBloodSorcery()
    {
        return bloodSorcery;
    }
    #endregion
}
public enum Clan 
{
    BanuHaqim,
    Brujah,
    Gangrel,
    Hecata,
    Lasombra,
    Malkavian,
    Ministry,
    Nosferatu,
    Ravnos,
    Toreador,
    Tremere,
    Tzimisce,
    Ventrue,
    Unset
}
public enum Rank 
{ 
    Ancilae,
    Elder,
    Harpy,
    Scourge,
    KeeperOfElysium,
    Primogen,
    Seneschal,
    Hound,
    Sheriff,
    Herald,
    Regent
}