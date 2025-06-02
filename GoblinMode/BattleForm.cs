using GoblinMode.Combat;

namespace GoblinMode
{

    public partial class BattleForm : Form
    {
        private int healthX;
        private UI.Combatant currentNPCUI;
        private UI.Combatant playerUI;
        private BattleFacade facade;

        public BattleForm(BattleFacade facade)
        {
            this.facade = facade;
            InitializeComponent();
            InitializeUI();

            facade.OnBattleWon += () => Close(); // Or play animation before closing
            facade.OnBattleLost += () =>
            {
                new LostGameForm().ShowDialog();
                Close();
            };
            facade.OnBattleEnded += () =>
            {
                Close();
            };
        }

        private void InitializeUI()
        {
            playerUI = facade.GetPlayerUI();
            currentNPCUI = facade.GetEnemyUI();

            NPCNameBox.DataBindings.Add("Text", currentNPCUI, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            NPCCurrentHealth.DataBindings.Add("Text", currentNPCUI, "CurrentHealth", false, DataSourceUpdateMode.OnPropertyChanged);
            NPCMaxHealth.DataBindings.Add("Text", currentNPCUI, "MaxHealth", false, DataSourceUpdateMode.OnPropertyChanged);

            PlayerNameBox.DataBindings.Add("Text", playerUI, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            PlayerCurrentHealth.DataBindings.Add("Text", playerUI, "CurrentHealth", false, DataSourceUpdateMode.OnPropertyChanged);
            PlayerMaxHealth.DataBindings.Add("Text", playerUI, "MaxHealth", false, DataSourceUpdateMode.OnPropertyChanged);

            NPCPortrait.Image = Image.FromFile(currentNPCUI.PortraitPath);
            PlayerPortrait.Image = Image.FromFile(playerUI.PortraitPath);

            NPCNameBox.Location = new Point(NPCNameBox.Location.X - (int)(NPCNameBox.Width * 1.5), NPCNameBox.Location.Y);
            healthX = NPCCurrentHealth.Location.X;

        }

        private void Attack(object sender, EventArgs e)
        {
            facade.PlayerAttack();
        }

        private void Run(object sender, EventArgs e)
        {
            facade.PlayerRun();
        }

        private void Block(object sender, EventArgs e)
        {
            facade.PlayerBlock();
        }

    }
}
