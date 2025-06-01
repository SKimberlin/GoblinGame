using System;
using GoblinMode.Character;

namespace GoblinMode.Combat
{
    public class BattleFacade
    {
        private BattleController controller;

        public event Action? OnBattleWon;
        public event Action? OnBattleLost;
        public event Action? OnBattleEnded;

        public BattleFacade(BattleController controller)
        {
            this.controller = controller;
        }

        public void PlayerAttack()
        {
            controller.Attack();
            controller.NPCTurn();
            CheckEndState();
        }

        public void PlayerBlock()
        {
            controller.Block();
            controller.NPCTurn();
            CheckEndState();
        }

        public void PlayerRun()
        {
            if (controller.Run())
            {
                OnBattleEnded?.Invoke(); // successfully escaped
                return;
            }
            controller.NPCTurn();
            CheckEndState();
        }

        private void CheckEndState()
        {
            if (controller.Win())
            {
                OnBattleWon?.Invoke();
            }
            else if (controller.Loss())
            {
                OnBattleLost?.Invoke();
            }
        }

        public UI.Combatant GetPlayerUI() => controller.GetPlayerUI();
        public UI.Combatant GetEnemyUI() => controller.GetCurrentNPCUI();
    }
}
