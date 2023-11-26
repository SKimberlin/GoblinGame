using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GoblinMode.Character
{
    public class NonPlayableCharacter : Character
    {
        short PlayerStanding;
        public Dialogue.Dialogue dialogue { get; set; }

        public override bool Read(string filename)
        {
            string json = File.ReadAllText(filename);

            NonPlayableCharacter character = JsonSerializer.Deserialize<NonPlayableCharacter>(json);

            this.name = character.name;
            this.portrait = Image.FromFile(character.portraitPath);
            //this.inventory = character.inventory;
            this.power = character.power;
            this.sneak = character.sneak;
            this.mischief = character.mischief;
            this.cunning = character.cunning;
            this.skitter = character.skitter;
            this.gleam = character.gleam;

            return true;
        }
    }
}
