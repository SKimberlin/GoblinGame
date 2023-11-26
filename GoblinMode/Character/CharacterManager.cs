using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GoblinMode.Character
{
    public class CharacterManager
    {
        private static CharacterManager instance;
        private List<Character> characters = new List<Character>();

        public static CharacterManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CharacterManager();
                }
                return instance;
            }
        }
        public void AddCharacter(Character character) 
        { 
            characters.Add(character);
        }
        public Character GetCharacterByID(int id) 
        {
            foreach (Character character in characters)
            {
                if (character.id == id)
                {
                    return character;
                }
            }
            return null;
        }
        public void ReplaceCharacterDataByID(int id, Character character) 
        {
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].id == id) 
                { 
                    characters.RemoveAt(i);
                    characters.Insert(i, character);
                }
            }
        }

        public void DeleteCharacterByID(int id)
        {
            for (int i = 0; i < characters.Count; i++) 
            { 
                if (characters[i].id == id) 
                { 
                    characters.RemoveAt(i); 
                } 
            }
        }
    }
}
