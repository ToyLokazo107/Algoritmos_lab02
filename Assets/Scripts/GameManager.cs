using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public SkillManager skillManager;

    void Start()
    {

        for (int i = 0; i < skillManager.todasLasSkills.Length; i++)
        {
            Skill skill = skillManager.todasLasSkills[i];
            Debug.Log(skill.nombre);
        }


        for (int i = 0; i < skillManager.todasLasSkills.Length; i++)
        {
            Skill skill = skillManager.todasLasSkills[i];

            bool puede = GameUtils.Validar<Skill>(skill, x => player.nivel >= x.nivelRequerido);

            if (puede)
            {
                Debug.Log("Puede aprender: " + skill.nombre);

                player.habilidades[i] = skill;
            }
            else
            {
                Debug.Log("NO puede aprender: " + skill.nombre);
            }
        }


        Skill skillEncontrada;

        bool encontrado = GameUtils.TryFind<Skill>(
            skillManager.todasLasSkills,
            x => x.id == 1,
            out skillEncontrada
        );

        if (encontrado)
        {
            Debug.Log("Encontrada: " + skillEncontrada.nombre);
        }
        else
        {
            Debug.Log("No se encontró la skill");
        }


        for (int i = 0; i < player.habilidades.Length; i++)
        {
            Skill skill = player.habilidades[i];

            if (skill != null)
            {
                GameUtils.Ejecutar<Skill>(skill, x => Debug.Log("Usando: " + x.nombre));
            }
        }
    }
}