using System;
using System.Drawing;
using System.Windows.Forms;
namespace PIM_2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bt_sair.ForeColor = Color.Red;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_CONTRASTE_Click(object sender, EventArgs e)
        {
            if (this.BackColor == SystemColors.Menu)
            {
                //><><><><><><><><><><><><><><><><><><><><><><>
                //          MODO    CONTRASTE =   ON
                //><><><><><><><><><><><><><><><><><><><><><><>

                this.BackColor = SystemColors.Desktop;

                //---------------------------------------------------
                //  COR DO BOTAO/ESPAÇO
                //---------------------------------------------------

                barra_menu.BackColor    = SystemColors.Desktop;
                bt_CONTRASTE.BackColor  = SystemColors.Desktop;
                bt_sair.BackColor       = SystemColors.Desktop;
                bt_frota.BackColor      = SystemColors.Desktop;
                bt_motorista.BackColor  = SystemColors.Desktop;
                bt_viagens.BackColor    = SystemColors.Desktop;
                bt_estoque.BackColor    = SystemColors.Desktop;
                bt_rela.BackColor       = SystemColors.Desktop;
                pic_car.BackColor       = SystemColors.Desktop;

                //---------------------------------------------------
                //  COR DO TEXTO
                //---------------------------------------------------

                barra_menu.ForeColor    = Color.Yellow;
                lb_relogio.ForeColor    = Color.Yellow;
                lb_versao.ForeColor     = Color.Yellow;
                bt_sair.ForeColor       = Color.Yellow;
                bt_CONTRASTE.ForeColor  = Color.Yellow;
                bt_frota.ForeColor      = Color.Yellow;
                bt_motorista.ForeColor  = Color.Yellow;
                bt_viagens.ForeColor    = Color.Yellow;
                bt_estoque.ForeColor    = Color.Yellow;
                bt_rela.ForeColor       = Color.Yellow;                
                lb_suporte.ForeColor    = Color.Yellow;
                //---------------------------------------------------
                //  ESTILO  FONTE
                //---------------------------------------------------

                barra_menu.Font     = new Font(barra_menu.Font  , FontStyle.Bold);
                lb_relogio.Font     = new Font(lb_relogio.Font  , FontStyle.Bold);
                lb_versao.Font      = new Font(lb_relogio.Font  , FontStyle.Bold);
                bt_sair.Font        = new Font(bt_sair.Font     , FontStyle.Bold);
                bt_CONTRASTE.Font   = new Font(bt_CONTRASTE.Font, FontStyle.Bold);
                bt_frota.Font       = new Font(bt_frota.Font    , FontStyle.Bold);
                bt_motorista.Font   = new Font(bt_motorista.Font, FontStyle.Bold);
                bt_viagens.Font     = new Font(bt_viagens.Font  , FontStyle.Bold);
                bt_estoque.Font     = new Font(bt_estoque.Font  , FontStyle.Bold);
                bt_rela.Font        = new Font(bt_rela.Font     , FontStyle.Bold);
                lb_suporte.Font     = new Font(lb_suporte.Font  , FontStyle.Bold);
            }
            else
            {
                //><><><><><><><><><><><><><><><><><><><><><><>
                //          MODO    CONTRASTE =   ON
                //><><><><><><><><><><><><><><><><><><><><><><>

                this.BackColor = SystemColors.Menu;

                //---------------------------------------------------
                //  COR DO BOTAO/ESPAÇO
                //---------------------------------------------------

                barra_menu.BackColor    = SystemColors.Control;
                bt_CONTRASTE.BackColor  = SystemColors.Control;
                bt_sair.BackColor       = SystemColors.Control;
                bt_frota.BackColor      = SystemColors.Control;
                bt_motorista.BackColor  = SystemColors.Control;
                bt_viagens.BackColor    = SystemColors.Control;
                bt_estoque.BackColor    = SystemColors.Control;
                bt_rela.BackColor       = SystemColors.Control;
                pic_car.BackColor       = SystemColors.Control;

                //---------------------------------------------------
                //  COR DO TEXTO
                //---------------------------------------------------

                barra_menu.ForeColor    = Color.Black;
                lb_relogio.ForeColor    = Color.Black;
                lb_versao.ForeColor     = Color.Black;
                bt_sair.ForeColor       = Color.Red;
                bt_CONTRASTE.ForeColor  = Color.Black;
                bt_frota.ForeColor      = Color.Black;
                bt_motorista.ForeColor  = Color.Black;
                bt_viagens.ForeColor    = Color.Black;
                bt_estoque.ForeColor    = Color.Black;
                bt_rela.ForeColor       = Color.Black;
                lb_suporte.ForeColor    = Color.Black;

                //---------------------------------------------------
                //  ESTILO  FONTE
                //---------------------------------------------------    

                barra_menu.Font     = new Font(barra_menu.Font  , FontStyle.Regular);
                lb_relogio.Font     = new Font(lb_relogio.Font  , FontStyle.Regular);
                lb_versao.Font      = new Font(lb_relogio.Font  , FontStyle.Regular);
                bt_sair.Font        = new Font(bt_sair.Font     , FontStyle.Regular);
                bt_CONTRASTE.Font   = new Font(bt_CONTRASTE.Font, FontStyle.Regular);
                bt_frota.Font       = new Font(bt_frota.Font    , FontStyle.Regular);
                bt_motorista.Font   = new Font(bt_motorista.Font, FontStyle.Regular);
                bt_viagens.Font     = new Font(bt_viagens.Font  , FontStyle.Regular);
                bt_estoque.Font     = new Font(bt_estoque.Font  , FontStyle.Regular);
                bt_rela.Font        = new Font(bt_rela.Font     , FontStyle.Regular);
                lb_suporte.Font     = new Font(lb_suporte.Font  , FontStyle.Regular);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_relogio.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}