using UnityEngine;

public class Teste : MonoBehaviour
{
    public Personagem personagem1;
    public Ninja ninja1;

    void Start()
    {
        
        personagem1.SetNome("Guerreiro");
        personagem1.SetVida(100);
        personagem1.SetForca(30);
        personagem1.SetVelocidade(5.5f);

        ninja1.SetNome("Ninja Sombra");
        ninja1.SetVida(80);
        ninja1.SetForca(25);
        ninja1.SetVelocidade(7.2f);
        ninja1.SetShurikens(10);
        ninja1.SetClones(3);
        
        Debug.Log($"Personagem: {personagem1.GetNome()} | Vida: {personagem1.GetVida()} | Força: {personagem1.GetForca()} | Velocidade: {personagem1.GetVelocidade()}");
        Debug.Log($"Ninja: {ninja1.GetNome()} | Vida: {ninja1.GetVida()} | Força: {ninja1.GetForca()} | Velocidade: {ninja1.GetVelocidade()} | Shurikens: {ninja1.GetShurikens()} | Clones: {ninja1.GetClones()} | Habilidade Especial: {ninja1.GetHabilidadeEspecial()}");

        // aquela parada da comparação
        bool ninjaMaisForte = ninja1.TemMaisForcaQue(personagem1);
        Debug.Log($"Ninja tem mais força que o Personagem? {ninjaMaisForte}");
    }
}