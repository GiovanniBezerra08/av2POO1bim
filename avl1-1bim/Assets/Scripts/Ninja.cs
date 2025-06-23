using UnityEngine;

public class Ninja : Personagem
{
    
    [SerializeField] private int shurikens;
    [SerializeField] private int clones;
    [SerializeField] private string habilidadeEspecial = "Clone das Sombras";

    public int GetShurikens() { return shurikens; }
    
    public void SetShurikens(int value) { shurikens = value; }

    
    public int GetClones() { return clones; }
    
    public void SetClones(int value) { clones = value; }

    
    public string GetHabilidadeEspecial() { return habilidadeEspecial; }
    
    public void SetHabilidadeEspecial(string value) { habilidadeEspecial = value; }
}