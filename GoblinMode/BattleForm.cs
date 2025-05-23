
namespace GoblinMode
{

    public partial class BattleForm : Form
    {
        private int healthX;
        private UI.Combatant currentNPCUI;
        private UI.Combatant playerUI;

        public BattleForm()
        {
            InitializeComponent();
            InitializeUI();
        }
        private void InitializeUI()
        {
            playerUI = BattleController.Instance.GetPlayerUI();
            currentNPCUI = BattleController.Instance.GetCurrentNPCUI();

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
            BattleController.Instance.Attack();
            BattleController.Instance.NPCTurn();
            WinLoss();
        }

        private void Run(object sender, EventArgs e)
        {
            if (BattleController.Instance.Run()) this.Close();
            BattleController.Instance.NPCTurn();
            WinLoss();
        }

        private void Block(object sender, EventArgs e)
        {
            BattleController.Instance.Block();
            BattleController.Instance.NPCTurn();
            WinLoss();
        }

        private void WinLoss()
        {
            if (BattleController.Instance.Win())
            {
                this.Close();
            }
            if (BattleController.Instance.Loss())
            {
                LostGameForm form = new LostGameForm();
                form.ShowDialog();
                this.Close();
            }
        }

    }
}
